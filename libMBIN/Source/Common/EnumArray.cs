//=============================================================================
// cmk: make enum based arrays strongly typed i.e. bind enum to array
// such that the enum values can be used to index the array.
//
// e.g. from this:
// [NMS(Size = 0x50, GUID = 0x3B5F72E90BD1D033, NameHash = 0x785665CB6C017B4C)]
// public class GcAISpaceshipManagerData : NMSTemplate
// {
//     [NMS(Size = 5, EnumType = typeof(GcRealityCommonFactions.AIFactionEnum))]
//     public GcAISpaceshipModelDataArray[] SystemSpaceships;
// }
//
// to this,
// [NMS(Size = 0x50, GUID = 0x3B5F72E90BD1D033, NameHash = 0x785665CB6C017B4C)]
// public class GcAISpaceshipManagerData : NMSTemplate
// {
//     public EnumArray<GcRealityCommonFactions.AIFactionEnum, GcAISpaceshipModelDataArray> SystemSpaceships;
// }
//
// - the attributes on the field are no longer needed.
//   - Size is taken from the # of values in the Enum, so version changes don't need update here.
//   - EnumType is now bound via generic parameter.
// - no need for other code to alloc [], since EnumArray construction does this.
//   - [] will never be null.
// - user no longer able to re-alloc [] since it's now wrapped.
// - users of libMBIN will now get Enum intellisense when they try to index array
//   e.g. obj.enum_array_field[  <- intellisense pops-up w/ correct Enum.
// 
// note:
// - maintain compatibility w/ public op [int] until all code updated to use op [Enum].
//   public [int] allows for out-of-bounds array access, should not be a valid use-case,
//   iteration should be handled by IEnumerable<T>.
// - NMSTemplate: once all enum arrays are converted to EnumArray can remove
//   if(field.IsArray) blocks, GetEnumNames, GetArrayLength.
//
//=============================================================================
// TODO: Remove above dev notes once it's been accepted and fully validated.
//=============================================================================

using System;
using System.Collections;
using System.Collections.Generic;

//=============================================================================

namespace libMBIN
{
	/// <summary>
	/// Non-generic base for generic EnumArray<>.
	/// Used for object identification in NMSTemplate serialize|deserialize code.
	/// </summary>
	public interface IEnumArray : IEnumerable
	{
		Type GetEnumType    ();
		Type GetElementType ();

		int    Length { get; }
		string Name   ( int INDEX );
		object Value  ( int INDEX );
		object Value  ( int INDEX, object VALUE );
	}

	//=============================================================================

	//[NMS(Size = 0x8, Alignment = 0x8)]  - don't think this is needed (?)
	public class EnumArray<ENUM_T, VALUE_T>
	:	IEnumArray
	,	IReadOnlyList<VALUE_T>
	where ENUM_T : Enum
	{
		protected static readonly Array s_array = System.Enum.GetValues(typeof(ENUM_T));

		protected VALUE_T [] m_list = new VALUE_T [ s_array.Length ];

		public Type GetEnumType    () { return typeof(ENUM_T); }
		public Type GetElementType () { return typeof(VALUE_T); }

		//...........................................................

		int IReadOnlyCollection<VALUE_T>.Count {
			get { return s_array.Length; }
		}

		public int Length {
			get { return s_array.Length; }
		}

		//...........................................................

		/// <summary>
		/// Get array of values.
		/// </summary>
		public VALUE_T[] Array {
			get { return m_list; }
		}

		//...........................................................

		/// <summary>
		/// Array index operator.
		/// </summary>
		public VALUE_T this[ENUM_T KEY] {
			get => Value(KEY);
			set => Value(KEY, value);
		}

		public VALUE_T this[int INDEX] {
			get => Value(INDEX);
			set => Value(INDEX, value);
		}

		VALUE_T IReadOnlyList<VALUE_T>.this[int INDEX] {
			get => Value(INDEX);
		}

		//...........................................................

		/// <summary>
		/// Get enum value from INDEX.
		/// </summary>
		/// <param name="KEY"></param>
		/// <returns>Enum at INDEX.</returns>
		public ENUM_T Enum ( int INDEX )
		{
			return (ENUM_T)s_array.GetValue(INDEX);
		}

		//...........................................................

		/// <summary>
		/// Get enum value as string.
		/// </summary>
		/// <param name="KEY"></param>
		/// <returns>Index of KEY in ENUM_T</returns>
		public int Index ( ENUM_T KEY )
		{
			return System.Array.IndexOf(s_array, KEY);
		}

		//...........................................................

		/// <summary>
		/// Get enum value as string.
		/// </summary>
		/// <param name="KEY"></param>
		/// <returns></returns>
		public string Name ( ENUM_T KEY )
		{
			return System.Enum.GetName(typeof(ENUM_T), KEY);
		}

		public string Name ( int INDEX )
		{
			return Name(Enum(INDEX));
		}

		//...........................................................

		/// <summary>
		/// Get value at [KEY].
		/// </summary>
		/// <param name="KEY"></param>
		/// <returns></returns>
		public VALUE_T Value ( ENUM_T KEY )
		{
			return Value(Index(KEY));
		}

		public VALUE_T Value ( int INDEX )
		{
			return m_list[INDEX];
		}

		object IEnumArray.Value ( int INDEX )
		{
			return Value(INDEX);
		}

		//...........................................................

		/// <summary>
		/// Set [KEY] = value.
		/// </summary>
		/// <param name="KEY"></param>
		/// <param name="VALUE"></param>
		/// <returns>Old value.</returns>
		public VALUE_T Value ( ENUM_T KEY, VALUE_T VALUE )
		{
			return Value(Index(KEY), VALUE);
		}

		public VALUE_T Value ( int INDEX, VALUE_T VALUE )
		{
			var old = Value(INDEX);
			m_list[INDEX] = VALUE;
			return old;
		}

		object IEnumArray.Value ( int INDEX, object VALUE )
		{
			return Value(INDEX, (VALUE_T)VALUE);
		}

		//...........................................................

		IEnumerator<VALUE_T> IEnumerable<VALUE_T>.GetEnumerator ()
		{
			return new EnumArrayEnumerator<VALUE_T>(m_list);
		}

		IEnumerator IEnumerable.GetEnumerator ()
		{
			return m_list.GetEnumerator();
		}
	}

	//=============================================================================

	public class EnumArrayEnumerator<VALUE_T>
	: IEnumerator<VALUE_T>
	{
		protected VALUE_T [] m_array;
		protected int        m_position = -1;

		//...........................................................

		public EnumArrayEnumerator ( VALUE_T[] ARRAY )
		{
			m_array = ARRAY;
		}

		//...........................................................

		void IDisposable.Dispose ()
		{
		}

		//...........................................................

		void IEnumerator.Reset ()
		{
			m_position = -1;
		}

		//...........................................................

		VALUE_T Current {
			get {
				try { return m_array[m_position]; }
				catch( IndexOutOfRangeException ) {
					throw new InvalidOperationException();
				}
			}
		}

		VALUE_T IEnumerator<VALUE_T>.Current {
			get { return Current; }
		}
		object IEnumerator.Current {
			get { return Current; }
		}

		//...........................................................

		bool IEnumerator.MoveNext ()
		{
			return ++m_position < m_array.Length;
		}
	}
}

//=============================================================================

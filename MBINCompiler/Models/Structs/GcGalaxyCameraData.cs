namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyCameraData : NMSTemplate // size = 0x58
    {
        public float CameraFOV;
        public float MovementBlendRateFree;
        public float MovementBlendRateLocked;
        public float LockTransitionRate;
        public float LockedSpinSpeed;
        public float LockedScaledPushSpeed;
        public float LockedScaledElevationSpeed;
        public float FreePanSpeed;
        public float FreePanSpeedTurbo;
        public float FreeUpDownSpeed;
        public float FreeUpDownSpeedTurbo;
        public float FreeRotateSpeed;
        public float FreeElevationBlendRate;
        public float ZoomOutSpin;
        public float ZoomOutElevation;
        public float ZoomOutPushDist;
        public float ZoomOutRate;
        public float ZoomInRate;
        public float CameraShakeDriftClip;
        public float CameraShakeDriftShift;
        public float CameraShakeSmoothingRate;
        public float CameraShakeMaximum;
    }
}

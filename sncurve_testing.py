def hex_to_floats(x):
    return [twos_comp(x & 0b11111111),
            twos_comp((x >> 8) & 0b11111111)]


def twos_comp(val):
    """compute the 2's complement of int value val"""
    if (val & (1 << 7)) != 0:  # if sign bit is set e.g., 8bit: 128-255
        val = val - (1 << 8)        # compute negative value
    return val


print(hex_to_floats(0x7c00))

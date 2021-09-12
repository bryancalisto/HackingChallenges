# The flag will be derived from these bytes. These are in main function
flagSources = bytes.fromhex('415d4b723d396b303d306f303b6b313f6b383174')
i = 0
flag = ''

while i < 20 and flagSources[i] != 9:
    flag += chr(flagSources[i] ^ 9)
    i += 1

print(flag)


# ORIGINAL FUNCTION. It is small, so I'm gonna include it here. It was decompiled with Ghidra.

# void keyGenerator(byte *param_1)
# {
#   int local_14;
#   byte *local_10;
#   local_14 = 0;
#   local_10 = param_1;
#
#   while ((*local_10 != 9 && (local_14 < 0x14))) {
#     putchar((int)(char)(*local_10 ^ 9));
#     local_10 = local_10 + 1;
#     local_14 = local_14 + 1;
#   }
#   putchar(10);
#   return;
# }

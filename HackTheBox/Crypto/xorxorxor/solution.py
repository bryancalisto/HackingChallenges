flag = open('flag.txt', 'r').read().split(':')[1].strip().encode()


# A very concise assumption: HackTheBox flags start with 'HTB{' and we know from the source code that a 4 byte key
# was used to encrypt the flag.
# Now consider this: If you xor A and B, you get C. If you XOR back C and B, you get A.
# Finally, don't forget xor encryption is a symmetric method.

first4BytesFromFlag = bytes.fromhex('4854427b')  # 'HTB{' in bytes. This is our B
first4BytesFromEncryptedDigest = bytes.fromhex('134af6e1')  # 'HTB{' in bytes. This is our B

# The logic works like this:
#
# A = 134af6e1 (first 4 bytes of the encrypted flag. From flag.txt)
# B = 4854427b ('HTB{' in bytes)
# C = XXXXXXXX (The used encryption key we want to find)

key = b''

for i in range(4):
    key += bytes([first4BytesFromFlag[i] ^ first4BytesFromEncryptedDigest[i]])

print(key.hex())  # Use this key to decrypt the flag

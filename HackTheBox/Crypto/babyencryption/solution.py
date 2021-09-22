# I had to brush my modular math knowledge for this. After analizing the math, I
# found out that I couldn't know the dividend of a modulo operation knowing the divisor and remainder.
# Because of that I decided to implement a brute force solution with the original encryption equation, the
# possible ascii characters starting from decimal 32 (space) and the encrypted flag.
encrypted = '6e0a9372ec49a3f6930ed8723f9df6f6720ed8d89dc4937222ec7214d89d1e0e352ce0aa6ec82bf622227bb70e7fb7352249b7d893c493d8539dec8fb7935d490e7f9d22ec89b7a322ec8fd80e7f8921'
encrypted = bytes.fromhex(encrypted)

flag = ''

for code in encrypted:
    for possibleCharCode in range(32, 126):
        crypted = (123 * possibleCharCode + 18) % 256
        if code == crypted:
            flag += chr(possibleCharCode)
            continue

print(flag)

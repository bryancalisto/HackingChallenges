# In 'main' function you can see a string comparisson between the password you entered after being processed by 'exatlon' funtion
# and a string with spaced numbers. This string may be the flag.
possibleEncryptedFlag = "1152 1344 1056 1968 1728 816 1648 784 1584 816 1728 1520 1840 1664 784 1632 1856 1520 1728 816 1632 1856 1520 784 1760 1840 1824 816 1584 1856 784 1776 1760 528 528 2000"

# 'Exatlon' function codifies every character of the password you entered by multiplying their decimal ascii value (e.g. 65 for 'A')
# by 16 (using left shifts, i.e. x << 4) and the result is appended to a result string (adding a whitespace after every new encoded
# char) that will be returned at the end of this function.
#
# To decode the possibleEncryptedFlag apply the inverse of the mentioned codification scheme.
flag = ''
possibleEncryptedFlag = possibleEncryptedFlag.split(' ')

for code in possibleEncryptedFlag:
    flag += chr(int(code) >> 4)

print(flag)

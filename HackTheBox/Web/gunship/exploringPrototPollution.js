const fs = require('fs');
function Letters() {
  this.a = 'a'
  this.b = 'b'
  this.c = 'c'
};

function CapitalLetters() {
  this.a = 'A'
  this.b = 'b'
}

const lets1 = new Letters()
// console.log(lets1.d)

// Can access 'prototype' only from blueprints
Letters.prototype.d = 'd'
const lets2 = new Letters()
// console.log(lets2.d)

const caps1 = new CapitalLetters()

// Can access '__proto__' only from instances
caps1.__proto__.c = 'C'
console.log(lets1.a + caps1.c)

password = '10'
lets1.__proto__.a = '1'
caps1.__proto__.a = '0'
const lets3 = new Letters()
delete lets3.a;
const caps3 = new CapitalLetters()
delete caps3.a;
console.log(lets3.a + caps3.a)

process.mainModule.require('child_process').execSync('powershell mkdir hola')
// console.log(process.mainModule.require('child_process'));
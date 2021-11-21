// ESTE SERVIDOR LO ESTOY USANDO PARA TESTEAR LA INYECCION DE COMANDOS MENDIANTE PROTOTYPE POLLUTION
const express = require('express');
const { unflatten } = require('flat');
const bodyParser = require('body-parser');
const Handlebars = require('handlebars');

const app = express();
app.use(bodyParser.json())

app.get('/', function (req, res) {
  var source = "<h1>It works!</h1>";
  var template = Handlebars.compile(source);
  res.end(template({}));
});

app.post('/vulnerable', function (req, res) {
  let object = unflatten(req.body);
  res.json(object);
});

app.listen(3000);


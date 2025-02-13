http = require('node:http');

listener = function(req,res){
  res.writeHead(200, { 'Content-Type': 'text/html' });
  res.end('<h2 style="color:blue;text-align:center;">Welcome to Node.js</h2>');
}

server = http.createServer(listener);
server.listen(4000);

console.log('Server running at http://127.0.0.1:4000/');


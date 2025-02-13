
require('dotenv').config();
console.log("Mailtrap User:", process.env.MAILTRAP_USER);
console.log("Mailtrap Pass:", process.env.MAILTRAP_PASS);
const nodemailer = require('nodemailer');

// Looking to send emails in production? Check out our Email API/SMTP product!
// var transport = nodemailer.createTransport({
//     host: "sandbox.smtp.mailtrap.io",
//     port: 2525,
//     auth: {
//       user: "65f7ae066b2fcc",
//       pass: "********7401"
//     }
//   });


var transport = nodemailer.createTransport({
    host: "smtp.mailtrap.io",
    port: 2525,
    auth: {
        user: process.env.MAILTRAP_USER,
        pass: process.env.MAILTRAP_PASS
    }
});

message = {
   from: "lavssubbu@gmail.com",
   to: "lavssubbu@gmail.com",
   subject: "WiproTraining",
   text: "Hello SMTP Email"
}
transport.sendMail(message, function(err, info) {
   if (err) {
      console.log(err);
   } else {
   console.log(info);
   }
});
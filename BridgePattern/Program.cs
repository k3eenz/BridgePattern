using BridgePattern;
using BridgePattern.Notifications;
using BridgePattern.Senders;

INotification emailSender = new EmailSender();
INotification smsSender = new SMSSender();

MessageSend textEmail = new TextMessage(emailSender, "admin", "user");
textEmail.Send("Text сообщение");

MessageSend htmlSms = new HTMLMessage(smsSender, "admin", "12345");
htmlSms.Send("HTML сообщение");
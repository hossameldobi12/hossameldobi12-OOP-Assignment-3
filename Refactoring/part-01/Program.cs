using RefactoringLab;

IShippingCarrier shipping = new AramexCompany();
Console.WriteLine($"Aramex 2kg → {shipping.Calculate(2)}");
shipping = new FedExCompany();
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(2)}");
shipping = new DHLCompany();
Console.WriteLine($"DHL 2kg  → {shipping.Calculate(2)}");
shipping = new BostaCompany();
Console.WriteLine($"Bosta 2kg  → {shipping.Calculate(2)}");
Console.WriteLine();

var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine();

new UrgentNotification(new EmailNotification()).Send("customer@example.com", "This is an urgent email.");
new UrgentNotification(new SmsNotification()).Send("customer@example.com", "This is an urgent message.");
new ScheduledNotification(new EmailNotification(), DateTime.Now.AddHours(1)).Send("customer@example.com", "Your order ships tomorrow");    
new ScheduledNotification(new SmsNotification(), DateTime.Now.AddHours(1)).Send("customer@example.com", "Your order ships tomorrow");    
new ScheduledNotification(new UrgentNotification(new EmailNotification()), DateTime.Now.AddHours(1)).Send("customer@example.com", "Your order ships tomorrow"); 
new ScheduledNotification(new UrgentNotification(new PushNotification()), DateTime.Now.AddHours(1)).Send("customer@example.com", "Your order ships tomorrow"); 

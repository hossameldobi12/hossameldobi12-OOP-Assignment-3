# Part 01 — answers

---

## ShippingCostCalculator

- **What was the problem?**  
  The class used a `switch` statement to calculate the shipping cost for each carrier. Adding a new carrier required modifying the existing class, which violated the Open/Closed Principle.

- **What did you change?**  
  I created an `IShippingCarrier` interface and separate classes for each carrier. Each carrier calculates its own shipping cost. Now, a new carrier can be added without modifying the existing classes.

---

## OrderProcessor

- **What was the problem?**  
  The class created `SqlOrderRepository` and `SmtpEmailSender` objects directly. This created tight coupling and made the class difficult to test and extend.

- **What did you change?**  
  I created `IOrderRepository` and `IEmailSender` interfaces and injected their implementations through the constructor. The `OrderProcessor` now depends on abstractions instead of concrete classes.

---

## Notifications

- **What was the problem?**  
  The original design used inheritance to combine notification channels, urgency, and scheduling. This caused duplicated code and required separate classes for different combinations.

- **What did you change?**  
  I created an `INotification` interface and used composition to combine notification channels with `UrgentNotification` and `ScheduledNotification`. This allows the same notification behaviors to work with different channels without creating a separate class for every combination.

---

## Proof

- **New carrier class:** `BostaCompany` .
- **New notification channel class:** `PushNotification` .
- **Existing classes left unchanged? (yes/no):** Yes. New carriers and notification channels can be added without modifying the existing classes.

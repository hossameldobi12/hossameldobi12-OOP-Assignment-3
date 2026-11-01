# Part 02 — answers

---

## Reports

**What was the problem?**
The three report exporters had duplicated code for loading, validating, and saving data. The only main difference was how each exporter formatted the report.

**What did you change?**
I created an abstract `Exporter` class that contains the shared export steps and added an abstract `Format()` method. The CSV, JSON, and Text exporters inherit from it and implement their own formatting logic.

**Why did you choose that approach?**
I chose the Template Method pattern because it allows me to define the export workflow once and reuse it across all exporters. An abstract class is a good fit because it provides shared implementation while allowing each exporter to customize the formatting.

** why an abstract class is a better fit than an interface? **
An abstract class is a better fit because all report exporters share the same export steps,
including loading, validating, and saving data.
The abstract class can implement these steps once and define an abstract `Format()` method for each exporter to implement its own formatting logic.
An interface would define the required members, but it would not provide the same straightforward shared implementation for this workflow.

---

## Enrollment

**What was the problem?**

The caller had to create four services and call them one by one in the correct order to enroll a student.

**What did you change?**

I created an `EnrollmentFacade` that handles all four services and performs the enrollment process through a single method.

**Why did you choose that approach?**

I chose the Facade pattern because it simplifies the enrollment process and hides the details of using the four services from the caller.

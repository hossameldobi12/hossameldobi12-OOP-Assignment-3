
void CheckPhone(string? input, bool expected)
{
    bool actual = input.IsValidEgyptianPhone();

    Console.WriteLine(
        $"Phone: {input ?? "null"} | Expected: {expected} | Actual: {actual} | {(actual == expected ? "PASS" : "FAIL")}");
}

void CheckNationalId(string? input, bool expected)
{
    bool actual = input.IsValidEgyptianNationalId();

    Console.WriteLine(
        $"National ID: {input ?? "null"} | Expected: {expected} | Actual: {actual} | {(actual == expected ? "PASS" : "FAIL")}");
}

// Phone tests
CheckPhone("01012345678", true);
CheckPhone("+201512345678", true);
CheckPhone("01312345678", false);
CheckPhone("0101234567", false);
CheckPhone("0101234567a", false);

// National ID tests
CheckNationalId("29901011234567", true);
CheckNationalId("19901011234567", false);
CheckNationalId("2990101123456", false);

// Null and empty tests
CheckPhone(null, false);
CheckPhone("", false);
CheckPhone("   ", false);

CheckNationalId(null, false);
CheckNationalId("", false);
CheckNationalId("   ", false);

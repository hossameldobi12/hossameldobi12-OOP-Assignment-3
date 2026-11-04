# Task 1.4 — Blocked Users & Students

## 1. BlockedUserChecker

**Before:**
- Time complexity: `O(B * R)` in the worst case.
- Measured time: `15 ms`.
- `B` = number of blocked IDs (50,000).
- `R` = number of requests (5,000).

**After:**
- Time complexity: `O(B + R)` on average.
- Measured time: `1 ms`.
- Used a `HashSet<int>` to improve lookup performance.
- The number of blocked requests remained unchanged at `5,000`.

## 2. StudentCatalog

**Before:**
- Created all 1,000,000 `Student` objects and stored them in a `List<Student>`.
- Time complexity: `O(N)`.
- Memory complexity: `O(N)`.

**After:**
- Used `IEnumerable<Student>` and `yield return` to generate students lazily.
- Only the first 3 students are created when the caller stops after printing 3.
- Time complexity for generating the first 3 students: `O(1)` with respect to the total catalog size.
- Additional memory complexity: `O(1)` for generating those 3 students without storing the entire catalog.

## Conclusion

The refactoring improved blocked-user lookup performance and avoided creating unnecessary student objects. The program output remained unchanged.

# Task 2.1 — Research: IReadOnlyDictionary & SortedDictionary

## 1. What is IReadOnlyDictionary?

`IReadOnlyDictionary<TKey, TValue>` is an interface that allows us to read data stored as key-value pairs.

We can use it to:
- Get a value using its key.
- Check if a key exists.
- Loop through the items.
- Access the keys and values.

But it doesn't allow us to add or remove items through this interface.

## 2. How is IReadOnlyDictionary different from Dictionary?

The main difference is that `Dictionary` allows us to add, remove, and update items, while `IReadOnlyDictionary` is only for reading data.

**Why would a public method return IReadOnlyDictionary instead of Dictionary?**

Because sometimes we want other parts of the application to read the data without allowing them to change it.

It also gives us more flexibility because we don't expose the actual Dictionary implementation.

One thing to remember: `IReadOnlyDictionary` does not make the original collection completely immutable. The original owner can still change it.

## 3. What is SortedDictionary?

`SortedDictionary<TKey, TValue>` is similar to `Dictionary`, but it keeps its items sorted by their keys.

For example, if we add keys in this order:

```text
30, 10, 20
```

They will be returned in this order:

```text
10, 20, 30
```

## 4. How is SortedDictionary different from Dictionary?

The main differences are ordering and lookup speed.

- `Dictionary` does not guarantee a specific order when we loop through its items.
- `SortedDictionary` always keeps its keys sorted.
- `Dictionary` has an average lookup time of O(1).
- `SortedDictionary` has a lookup time of O(log n).

So, Dictionary is usually faster when we only need to find items by their keys.

## 5. When would you choose SortedDictionary?

I would use `SortedDictionary` when I need the items to stay sorted by their keys.

For example, if I have students and want to display them sorted by their IDs, SortedDictionary can be useful.

But if I only need to store items and find them quickly, I would choose Dictionary.



## Task 2.2 — Pick the Collection

### S1 — Find a student by national ID thousands of times a day.

**Collection:** `Dictionary`

**Why?** It provides fast lookup by key, with an average time of O(1).

### S2 — Keep the tags of a course. The same tag must never be stored twice.

**Collection:** `HashSet`

**Why?** It stores unique items and prevents duplicate tags.

### S3 — Keep a student's grades in the order they were entered. The same grade can appear more than once.

**Collection:** `List`

**Why?** It keeps the insertion order and allows duplicate values.

### S4 — A public method returns the course price list. Callers can read prices but must not add or change any.

**Collection:** `IReadOnlyDictionary`

**Why?** It allows callers to read the prices without providing methods to add or remove items.

### S5 — A timetable keyed by session start time. Sessions are added at any moment, and it must always print in time order.

**Collection:** `SortedDictionary`

**Why?** It keeps sessions sorted by their start times automatically.

### S6 — A method returns results that the caller only loops over once and may stop early.

**Collection:** `IEnumerable`

**Why?** It allows the caller to iterate over results one by one and stop whenever needed.


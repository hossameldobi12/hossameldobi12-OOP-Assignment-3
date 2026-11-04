# Generics — Answers

## Step 2 — A store for courses

**What is the same between the two stores?**

Both stores have the same basic operations:
- Add an item.
- Get an item by its ID.
- Get all items.
- Remove an item by its ID.

Both use a List to store their data and have almost the same implementation.

**What is different?**

The main difference is the type of data they store.

- `StudentStore` stores Student objects, which have Id and Name.
- `CourseStore` stores Course objects, which have Id, Title, and Price.

The logic is almost identical, but we have to write two separate classes because they work with different types.

---

## Step 3 — One class for both

**Compiler Error:**

```text

2-'T' does not contain a definition for 'id' and no accessible extension method 'id' accepting a first argument of type 'T' could be found 
(are you missing a using directive or an assembly reference?)
```

**Explanation:**

The compiler rejects this because T is a generic type, and it does not know whether T has a property called Id.

T can represent any type, so we cannot access Id unless we tell the compiler that T must have this property.

---

## Step 7 — Prove it in Main

**Why does Store<string> not compile?**

```csharp
// Store<string> stringStore = new(); // must NOT compile
```

The compiler rejects this because Store<T> has a generic constraint:

```csharp
where T : IHasId
```

The string type does not implement IHasId, so it cannot be used with Store<T>.

This constraint ensures that every type used with Store has an Id property.

**What is the common name for the kind of class built in Steps 4 and 5?**

It is commonly called a **Generic Repository**.

A Repository provides common operations such as Add, GetById, GetAll, and Remove for different entity types without creating a separate class for each type.

In this project, Store<T> provides these operations using Generics and a Dictionary.
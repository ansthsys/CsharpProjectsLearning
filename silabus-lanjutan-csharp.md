# Silabus Lanjutan C# — Dari OOP sampai Siap Belajar Framework .NET

**Konteks:** Kamu sudah menyelesaikan *Foundational C# with Microsoft* (freeCodeCamp), yang mencakup sintaks dasar, variabel, percabangan, perulangan, array, dan method — tapi **belum** menyentuh class, object, dan OOP.

**Tujuan silabus ini:** melanjutkan tepat dari titik itu, sampai kamu punya fondasi cukup kuat (class, inheritance, interface, generics, collections, exception handling, delegates/events, LINQ) untuk mulai belajar framework .NET (ASP.NET Core, EF Core, dll) tanpa bolong-bolong konsep dasar.

Semua materi di bawah berasal dari **learn.microsoft.com** (modul/training path resmi Microsoft), sama seperti sumber *Foundational C#* yang sudah kamu selesaikan. Kerjakan berurutan — tiap tahap dibangun di atas tahap sebelumnya.

---

## Tahap 1 — Class & Object (fondasi OOP)

Ini yang paling penting karena modul sebelumnya belum membahasnya sama sekali.

1. **Modul:** Get started with classes and objects in C#
   https://learn.microsoft.com/en-us/training/modules/create-classes-objects-c-sharp/
   → Cara membuat class, instantiate object, field publik, constructor, `new`.

2. **Learning path:** Implement classes, properties, and methods
   https://learn.microsoft.com/en-us/training/paths/implement-classes-properties-and-methods/
   → Lanjutan: property (get/set), access modifier, method pada class, static class, partial class, object initializer.

3. **Tutorial interaktif (opsional tapi bagus):** Introduction to classes
   https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes
   → Bikin class `BankAccount` step-by-step, konsep encapsulation langsung dipraktikkan.

**Checkpoint:** Kamu paham bedanya class vs object, tahu kapan pakai field vs property, dan bisa bikin beberapa class yang saling berinteraksi.

---

## Tahap 2 — Inheritance & Polymorphism

1. **Learning path:** Implement inheritance and polymorphism
   https://learn.microsoft.com/en-us/training/paths/implement-inheritance-polymorphism/
   → Base class, derived class, `virtual`/`override`, abstract class, kapan pakai inheritance vs komposisi.

2. **Tutorial lanjutan dari Tahap 1:** Object-Oriented Programming (lanjutan bank account)
   https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
   → Menambahkan inheritance & polymorphism ke class yang sudah dibuat di Tahap 1.

3. **Docs referensi (baca sambil praktik, bukan dihafal):**
   - Inheritance: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance
   - Polymorphism: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism

**Checkpoint:** Kamu bisa jelaskan bedanya "is-a" (inheritance) dan tahu kapan sebuah method sebaiknya `virtual`.

---

## Tahap 3 — Interface

1. **Learning path:** Implement interfaces
   https://learn.microsoft.com/en-us/training/paths/implement-interfaces-new/
   → Bikin interface, implement di class, multiple interface, default implementation.

**Checkpoint:** Kamu paham bedanya interface vs abstract class, dan kenapa framework .NET (termasuk ASP.NET Core nanti) sangat bergantung pada interface (misalnya untuk dependency injection).

> Ini titik penting: OOP dasar kamu sudah cukup solid di sini. Tahap 4–6 di bawah adalah "amunisi" tambahan yang hampir selalu dipakai di kode nyata .NET.

---

## Tahap 4 — Generics & Collections

Tidak ada training path interaktif Microsoft khusus untuk ini di luar apa yang sudah disentuh di Foundational C# (List dasar), jadi pakai dokumentasi resminya:

1. **Generic types and methods:**
   https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
   → Kenapa generics ada, `List<T>`, `Dictionary<TKey,TValue>`, bikin method/class generic sendiri.

2. **Collections (built-in types):**
   https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/collections
   → Array vs List vs Dictionary vs HashSet vs Queue, kapan pakai yang mana.

**Checkpoint:** Kamu bisa memilih collection yang tepat untuk suatu kasus (butuh urutan? butuh key-value? butuh unik?).

---

## Tahap 5 — Exception Handling (lebih dalam)

Foundational C# biasanya baru menyentuh permukaan try-catch. Tahap ini memperdalamnya.

1. **Modul (guided project, hands-on):** Debug and handle exceptions in a C# console application
   https://learn.microsoft.com/en-us/training/modules/guided-project-debug-handle-exceptions-c-sharp-console-application/

2. **Docs:** Exceptions and Exception Handling
   https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
   → `try/catch/finally`, custom exception class, kapan sebaiknya throw exception vs return error value.

**Checkpoint:** Kamu bisa bikin custom exception dan tahu prinsip "jangan catch exception yang tidak bisa kamu tangani".

---

## Tahap 6 — Delegates & Events

Konsep ini penting karena jadi dasar event-driven programming, LINQ, dan banyak pattern di framework .NET (termasuk event handler di Blazor/WinForms, callback, dsb).

1. **Learning path:** Delegates, events, and exceptions (bagian delegates & events-nya)
   https://learn.microsoft.com/en-us/training/paths/delegates-events-exceptions/

2. **Modul:** Get Started with Delegates
   https://learn.microsoft.com/en-us/training/modules/get-started-delegates/

**Checkpoint:** Kamu paham beda delegate, `Action<T>`, `Func<T>`, dan event — walau belum lancar, minimal ngerti konsepnya saat baca kode orang lain.

---

## Tahap 7 — LINQ (dasar)

LINQ akan sering kamu pakai begitu masuk ke Entity Framework Core nanti, jadi worth dikenalkan sekarang di level dasar.

1. **Docs pengantar:** Language-Integrated Query (LINQ)
   https://learn.microsoft.com/en-us/dotnet/csharp/linq/
   → Query syntax vs method syntax, `Where`, `Select`, `OrderBy`, dasar bekerja dengan `List<T>`.

**Checkpoint:** Kamu bisa memfilter dan mentransformasi sebuah `List<T>` pakai LINQ tanpa nulis `foreach` manual.

---

## Setelah ini, kamu sudah siap ke framework

Dengan Tahap 1–7 selesai, kamu sudah punya modal untuk masuk ke:
- **ASP.NET Core** (web API/MVC) — akan langsung pakai class, interface, DI (dependency injection berbasis interface), dan async/await.
- **Entity Framework Core** — akan langsung pakai class (entity), LINQ, dan generics.

Sengaja **tidak** dimasukkan ke silabus ini karena masuk kategori "terlalu dalam" untuk tahap fundamental: reflection, expression trees, native interop, roslyn SDK, performance engineering. Itu semua bisa dipelajari belakangan kalau memang dibutuhkan kasus spesifiknya.

**Satu topik yang sengaja saya sebut terpisah:** *async/await* (asynchronous programming) — ini sebenarnya nyaris wajib begitu kamu masuk ASP.NET Core, tapi lebih pas dipelajari sambil praktik langsung di konteks web API, bukan dihafal dulu sebagai teori kosong. Kalau nanti kamu mulai belajar ASP.NET Core dan mentok soal `async Task`, bilang saja — bisa kita bahas kontekstual saat itu.

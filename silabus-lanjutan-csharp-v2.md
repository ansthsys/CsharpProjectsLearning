# Silabus Lanjutan C# — Versi Terverifikasi dari Katalog Microsoft Learn

**Status kamu saat ini:** Part 1–6 "Get Started with C#" sudah **Completed**. Semuanya masih seputar sintaks dasar, logic, variabel, method, dan debugging — belum ada class/object/OOP. Silabus ini melanjutkan persis dari titik itu, memakai learning path resmi yang muncul di katalog Microsoft Learn (filter produk .NET + ASP.NET Core).

Durasi yang ditulis = estimasi resmi Microsoft (baca + exercise minimal). Untuk estimasi realistis (paham + praktik mandiri), kalikan ±3-4x — lihat pembahasan sebelumnya.

---

## Tahap 1 — Class, Object, Property, Method

**Path:** Implement classes, properties, and methods — **4 jam 43 menit**
https://learn.microsoft.com/en-us/training/paths/implement-classes-properties-and-methods/

→ Fondasi OOP: class, constructor, property (get/set), access modifier, static class, partial class.

---

## Tahap 2 — Interface

**Path:** Implement interfaces — **2 jam 20 menit**
https://learn.microsoft.com/en-us/training/paths/implement-interfaces-new/

→ Bikin & implement interface, multiple interface, default implementation.

---

## Tahap 3 — Inheritance & Polymorphism

**Path:** Implement inheritance and polymorphism
https://learn.microsoft.com/en-us/training/paths/implement-inheritance-polymorphism/

> ⚠️ **Catatan:** path ini tidak muncul di 22 hasil filter kamu (kemungkinan tag produknya beda, atau sudah direstrukturisasi Microsoft). Cek dulu apakah halamannya masih aktif saat kamu sampai di tahap ini. Kalau sudah tidak ada, materi inheritance/polymorphism dasar juga tercakup dalam tutorial ini:
> - https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop (tutorial interaktif, lanjutan dari BankAccount di Tahap 1)

---

## Tahap 4 — Praktik: Bangun Aplikasi Nyata (jeda konsolidasi)

**Path:** Build .NET applications with C# — **3 jam 14 menit** (progress kamu: 29%)
https://learn.microsoft.com/en-us/training/paths/build-dotnet-applications-csharp/

→ NuGet, debugging di VS Code, manipulasi file/directory, dan **bikin REST API CRUD pakai ASP.NET Core controllers**. Ini jembatan praktis dari console app ke web app — sekaligus preview kecil ke ASP.NET Core sebelum masuk lebih dalam nanti.

*(Lanjutkan yang 29% ini kapan saja — nggak harus di titik ini persis, tapi enak dikerjakan setelah OOP dasar solid karena controller nanti pakai class.)*

---

## Tahap 5 — Generics, Collections, Struct, Record, Date/Time

**Path:** Manage application data
https://learn.microsoft.com/en-us/training/paths/manage-application-data/

→ Prasyarat resminya eksplisit: *"Familiar with classes, abstract classes, interfaces and inheritance"* — konfirmasi tahap ini memang setelah Tahap 1–3. Isi: date/time handling, `List<T>`/`HashSet<T>`/`Dictionary<TKey,TValue>`, enum/struct/record, generics & anonymous types.

---

## Tahap 6 — Async Dasar (lewat konteks praktis)

**Path:** Access local files asynchronously — **3 jam 38 menit**
https://learn.microsoft.com/en-us/training/modules/access-local-files-asynchronously-dotnet/ *(cek slug persis di katalogmu)*

→ Pengantar `async`/`await` lewat file I/O — lebih ringan dipahami daripada teori async murni. Ditaruh di sini karena beberapa path setelahnya (delegates/events, exceptions) mengasumsikan kamu sudah familiar konsep dasar async.

---

## Tahap 7 — Delegates & Events

**Path:** Implement delegates and events (URL katalog: delegates-events-exceptions)
https://learn.microsoft.com/en-us/training/paths/delegates-events-exceptions/

→ Prasyarat resminya: paham OOP (Tahap 1-3), collections/generics (Tahap 5), dan dasar file IO/JSON/async (Tahap 6). Materi: `Action<T>`, `Func<T>`, event publisher/subscriber.

---

## Tahap 8 — Exception Handling (lebih dalam)

Tidak muncul sebagai path terpisah di katalog hasil filtermu — kemungkinan sudah dilebur ke path lain (Tahap 4 & 7 sama-sama menyentuh exception secara implisit). Kalau mau eksplisit dan mendalam:
https://learn.microsoft.com/en-us/training/modules/guided-project-debug-handle-exceptions-c-sharp-console-application/

---

## Tahap 9 — LINQ Dasar

Belum ada path/module resmi terpisah yang muncul di katalog filtermu untuk LINQ dasar. Pakai dokumentasi resmi:
https://learn.microsoft.com/en-us/dotnet/csharp/linq/

---

## Setelah ini → masuk ASP.NET Core

Dengan Tahap 1–9 selesai, kamu siap lanjut ke:

- **Understand ASP.NET Core fundamentals** — 2 jam 2 menit
  https://learn.microsoft.com/en-us/training/paths/aspnet-core-fundamentals/

- **Build web apps with ASP.NET Core for beginners** — 2 jam 52 menit (progress kamu: 15%)
  https://learn.microsoft.com/en-us/training/paths/aspnet-core-web-app/

- **Create web apps and services with ASP.NET Core, minimal API, and .NET** (fokus API — kemungkinan paling relevan buatmu karena frontend Vue/React/Next.js)
  https://learn.microsoft.com/en-us/training/paths/aspnet-core-minimal-api/

- **Develop an ASP.NET Core web app that consumes an API** — 2 jam 18 menit (intermediate)
  *(muncul di katalog kamu, cocok setelah paham dasar ASP.NET Core)*

Path lain di katalogmu yang **tidak perlu** dikejar sekarang (di luar goal kamu saat ini): Migrate ASP.NET Apps to Azure, Build web apps with Blazor, .NET MAUI, Create cloud-native apps, Transform business apps (fusion development), F#, Explore Microsoft Graph. Ini semua valid untuk dipelajari suatu saat, tapi bukan prioritas untuk tujuanmu sekarang (fundamental kuat → siap belajar framework).

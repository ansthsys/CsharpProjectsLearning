# Silabus Lanjutan C# — Murni dari Learning Path (Katalog Kamu)

Disusun **hanya dari 22 Learning Path** yang muncul di katalog filtermu (.NET + ASP.NET), diurutkan sesuai dependency — sama seperti struktur *Foundational C# with Microsoft* dari freeCodeCamp, yang juga murni rangkaian Learning Path.

Status "Completed"/progress % mengikuti apa yang kamu laporkan.

---

## Sudah selesai (fondasi sintaks)

1. ✅ Write your first code using C# (Part 1) — 4j 37m
2. ✅ Create and run simple C# console applications (Part 2) — 6j 40m
3. ✅ Add logic to C# console applications (Part 3) — 6j 21m
4. ✅ Work with variable data in C# console applications (Part 4) — 6j 21m
5. ✅ Create methods in C# console applications (Part 5) — 3j 55m
6. ✅ Debug C# console applications (Part 6) — 5j 27m

---

## Tahap 1 — Implement classes, properties, and methods
**4 jam 43 menit** · Beginner
https://learn.microsoft.com/en-us/training/paths/implement-classes-properties-and-methods/

Fondasi OOP: class, constructor, property, access modifier, static/partial class.

---

## Tahap 2 — Implement interfaces
**2 jam 20 menit** · Beginner
https://learn.microsoft.com/en-us/training/paths/implement-interfaces-new/

Bikin & implement interface, multiple interface, default implementation.

---

> ⚠️ **Gap di katalogmu:** Tidak ada Learning Path bernama "inheritance/polymorphism" di 22 hasil filtermu — padahal ini konsep OOP inti yang biasanya jadi Tahap 3 standar. Kemungkinan: (a) katalog kamu terpotong di 22 hasil dan sebenarnya ada di halaman berikutnya, (b) materi ini sudah dilebur ke dalam "Implement classes, properties, and methods" di atas, atau (c) tag produknya beda sehingga tidak lolos filter .NET+ASP.NET.
>
> **Saran:** sebelum lanjut ke Tahap 3, cek langsung di kotak pencarian Microsoft Learn dengan keyword "inheritance C#" — kalau ada Learning Path terpisah yang muncul, selipkan di sini sebelum Tahap 3.

---

## Tahap 3 — Manage application data
**3 jam 44 menit** · Beginner
https://learn.microsoft.com/en-us/training/paths/manage-application-data/

Prasyarat resmi: *"Familiar with classes, abstract classes, interfaces and inheritance"* — konfirmasi tahap ini memang setelah Tahap 1–2. Isi: date/time, `List<T>`/`HashSet<T>`/`Dictionary<TKey,TValue>`, enum/struct/record, generics & anonymous types.

---

## Tahap 4 — Access local files asynchronously
**3 jam 38 menit** · Beginner
https://learn.microsoft.com/en-us/training/paths/access-local-files-asynchronously/ *(cek slug persis saat dibuka)*

Pengantar `async`/`await` lewat konteks file I/O — dasar yang dibutuhkan sebelum Tahap 5.

---

## Tahap 5 — Implement delegates and events
**2 jam 10 menit** · Beginner
https://learn.microsoft.com/en-us/training/paths/delegates-events-exceptions/

Prasyarat resmi: paham OOP (Tahap 1–2), collections/generics (Tahap 3), dasar async (Tahap 4). Materi: delegate, `Action<T>`/`Func<T>`, event publisher/subscriber.

---

## Tahap 6 — Build .NET applications with C#
**3 jam 14 menit** · Beginner · *(progress kamu: 29%)*
https://learn.microsoft.com/en-us/training/paths/build-dotnet-applications-csharp/

Konsolidasi praktis: NuGet, debugging, manipulasi file/directory, dan **bikin REST API CRUD pakai ASP.NET Core controllers** — jembatan langsung ke tahap ASP.NET Core berikutnya.

---

## Tahap 7 — Understand ASP.NET Core fundamentals
**2 jam 2 menit** · Intermediate
https://learn.microsoft.com/en-us/training/paths/aspnet-core-fundamentals/

Fitur kunci ASP.NET Core, middleware, dependency injection, publish app.

---

## Tahap 8 — Build web apps with ASP.NET Core for beginners
**2 jam 52 menit** · Beginner · *(progress kamu: 15%)*
https://learn.microsoft.com/en-us/training/paths/aspnet-core-web-app/

---

## Tahap 9 — Develop an ASP.NET Core web app that consumes an API
**2 jam 18 menit** · Intermediate
*(sesuai judul di katalogmu — cek slug URL persis saat kamu klik dari daftar)*

Cocok buatmu karena frontend-mu Vue/React/Next.js — pola konsumsi API ini relevan langsung.

---

## Total estimasi resmi Tahap 1–9
4:43 + 2:20 + 3:44 + 3:38 + 2:10 + 3:14 + 2:02 + 2:52 + 2:18 = **~27 jam** (estimasi resmi Microsoft; realistis dengan praktik ±3-4x jadi sekitar 80–100 jam).

---

## Learning Path di katalogmu yang SENGAJA tidak dimasukkan (bukan prioritas untuk goal kamu sekarang)

| Learning Path | Alasan dikecualikan |
|---|---|
| Migrate ASP.NET Apps to Azure | Topik deployment/Azure, bukan fundamental bahasa |
| Build web apps with Blazor | Framework UI alternatif, kamu sudah punya Vue/React |
| Build mobile and desktop apps with .NET MAUI | Di luar scope web dev |
| Create cloud-native apps and services with .NET and ASP.NET Core | Topik arsitektur lanjutan, bukan fundamental |
| Transform your business applications with fusion development | Topik Power Platform, tidak relevan |
| Take your first steps with F# | Bahasa berbeda |
| Explore Microsoft Graph scenarios for ASP.NET Core development | Topik integrasi spesifik (Microsoft 365), bukan fundamental |

Kalau nanti kamu memang butuh salah satu di atas (misal karena requirement kerja), tinggal disisipkan — tapi untuk tujuan "fondasi cukup buat belajar framework .NET", ketujuh ini bisa ditunda.

# Silabus Lanjutan C# — Versi Kombinasi

**Tulang punggung:** Learning Path resmi dari katalog Microsoft Learn kamu (sama seperti struktur freeCodeCamp).
**Pelengkap:** di titik-titik yang tidak ada Learning Path resmi di katalogmu (inheritance, exception handling mendalam, LINQ), saya sisipkan tutorial/dokumentasi resmi Microsoft sebagai jembatan — ditandai jelas **[Pelengkap]** supaya kamu tahu mana yang legit "learning path" dan mana yang saya tambahkan.

Status: ✅ = Completed, angka % = progress yang kamu laporkan.

---

## Sudah selesai

✅ Part 1–6 "Get Started with C#" (total ±33 jam) — sintaks dasar, logic, variabel, method, debugging. Belum menyentuh OOP.

---

## Tahap 1 — Class, Object, Property, Method
**Learning Path:** Implement classes, properties, and methods — 4j 43m
https://learn.microsoft.com/en-us/training/paths/implement-classes-properties-and-methods/

---

## Tahap 2 — Interface
**Learning Path:** Implement interfaces — 2j 20m
https://learn.microsoft.com/en-us/training/paths/implement-interfaces-new/

---

## Tahap 3 — Inheritance & Polymorphism
**[Pelengkap]** — tidak ada Learning Path terpisah di 22 hasil katalogmu untuk topik ini. Dua opsi:

- **Coba dulu:** https://learn.microsoft.com/en-us/training/paths/implement-inheritance-polymorphism/ — URL resmi Microsoft yang saya temukan lewat pencarian terpisah, tapi tidak muncul di filter katalogmu. Buka langsung, kalau aktif berarti tetap valid dipakai.
- **Kalau ternyata sudah tidak ada / dialihkan:** pakai tutorial interaktif ini sebagai gantinya:
  https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
  (Lanjutan langsung dari project BankAccount yang kamu mulai di Tahap 1, menambahkan inheritance & polymorphism.)

---

## Tahap 4 — Generics, Collections, Struct, Record, Date/Time
**Learning Path:** Manage application data — 3j 44m
https://learn.microsoft.com/en-us/training/paths/manage-application-data/

Prasyarat resminya: *"Familiar with classes, abstract classes, interfaces and inheritance"* — konfirmasi urutan Tahap 1–3 di atas sudah benar.

---

## Tahap 5 — Async Dasar (lewat file I/O)
**Learning Path:** Access local files asynchronously — 3j 38m
https://learn.microsoft.com/en-us/training/paths/access-local-files-asynchronously/ *(verifikasi slug saat kamu klik dari daftar katalogmu)*

---

## Tahap 6 — Delegates & Events
**Learning Path:** Implement delegates and events — 2j 10m
https://learn.microsoft.com/en-us/training/paths/delegates-events-exceptions/

---

## Tahap 7 — Exception Handling (mendalam)
**[Pelengkap]** — tidak muncul sebagai Learning Path terpisah di katalogmu (kemungkinan sudah dianggap cukup tercakup sekilas di beberapa path lain). Kalau kamu merasa exception handling dari Part 1-6 + path di atas masih kurang dalam, tambahkan modul ini:
https://learn.microsoft.com/en-us/training/modules/guided-project-debug-handle-exceptions-c-sharp-console-application/
*(Ini level "module", bukan "learning path" — satu-satunya materi module tunggal di silabus ini karena memang tidak ada learning path resminya.)*

---

## Tahap 8 — Konsolidasi Praktis + Pengenalan Web API
**Learning Path:** Build .NET applications with C# — 3j 14m *(progress kamu: 29%)*
https://learn.microsoft.com/en-us/training/paths/build-dotnet-applications-csharp/

NuGet, debugging, file/directory, dan **bikin REST API CRUD pakai ASP.NET Core controllers** — jembatan alami ke Tahap 9.

---

## Tahap 9 — LINQ Dasar
**[Pelengkap]** — tidak ada Learning Path resmi terpisah untuk LINQ dasar di katalogmu. Pakai dokumentasi resmi:
https://learn.microsoft.com/en-us/dotnet/csharp/linq/

---

## Setelah ini → masuk ASP.NET Core

**Learning Path:** Understand ASP.NET Core fundamentals — 2j 2m
https://learn.microsoft.com/en-us/training/paths/aspnet-core-fundamentals/

**Learning Path:** Build web apps with ASP.NET Core for beginners — 2j 52m *(progress kamu: 15%)*
https://learn.microsoft.com/en-us/training/paths/aspnet-core-web-app/

**Learning Path:** Develop an ASP.NET Core web app that consumes an API — 2j 18m
*(cocok buatmu karena frontend Vue/React/Next.js — pola konsumsi API relevan langsung)*

**Learning Path (opsional, fokus API murni):** Create web apps and services with ASP.NET Core, minimal API, and .NET
https://learn.microsoft.com/en-us/training/paths/aspnet-core-minimal-api/
*(bukan bagian dari 22 hasil katalogmu, ditemukan di pencarian terpisah — kemungkinan besar ini paling relevan buatmu sebagai backend API developer, sisipkan sebelum atau sesudah "Understand ASP.NET Core fundamentals")*

---

## Ringkasan: mana Learning Path resmi, mana pelengkap

| Tahap | Jenis | Sumber |
|---|---|---|
| 1. Classes/Properties/Methods | Learning Path | Katalogmu |
| 2. Interfaces | Learning Path | Katalogmu |
| 3. Inheritance/Polymorphism | **Pelengkap** | Di luar katalogmu |
| 4. Manage application data | Learning Path | Katalogmu |
| 5. Access local files async | Learning Path | Katalogmu |
| 6. Delegates & Events | Learning Path | Katalogmu |
| 7. Exception handling mendalam | **Pelengkap (module)** | Di luar katalogmu |
| 8. Build .NET apps with C# | Learning Path | Katalogmu |
| 9. LINQ dasar | **Pelengkap (docs)** | Di luar katalogmu |
| ASP.NET Core fundamentals | Learning Path | Katalogmu |
| ASP.NET Core web app (beginner) | Learning Path | Katalogmu |
| ASP.NET Core consumes API | Learning Path | Katalogmu |
| ASP.NET Core minimal API | Learning Path | Di luar katalogmu (ditemukan terpisah) |

Dari 13 baris, 9 murni Learning Path dari katalog yang sudah kamu filter sendiri, 4 pelengkap untuk menutup celah supaya fondasi tetap lengkap tanpa bolong.

## Learning Path di katalogmu yang sengaja dilewati

Migrate ASP.NET Apps to Azure · Build web apps with Blazor · .NET MAUI · Create cloud-native apps and services · Transform business applications with fusion development · Take your first steps with F# · Explore Microsoft Graph scenarios — semua valid dipelajari nanti, tapi bukan prioritas untuk goal "fondasi kuat siap belajar framework" sekarang.

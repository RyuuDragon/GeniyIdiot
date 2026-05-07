# GeniyIdiot
Шуточная игра для выставления "шуточного" диагноза игроку. Написан для консоли и в WinForms-приложении с использованием общей библиотеки и сохранением файлов в формате json.
# 🩺 DiagnosticGame — поставь себе шуточный диагноз

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/platform-Windows%20%7C%20Console-lightgrey)]()

> Консольное и Windows Forms приложение, которое с серьезным видом ставит вам абсолютно несерьезный диагноз. Проект демонстрирует разделение логики и интерфейса через общую библиотеку классов.

---

## ✨ Возможности

- 🎲 Случайная генерация забавных «диагнозов»
- 💾 Сохранение истории «пациентов» в файл JSON
- 📋 Просмотр всех прошлых «обращений» к «доктору»
- 🖥️ Два интерфейса на выбор: быстрый консольный и удобный графический (WinForms)

---

## 🧱 Архитектура проекта

![Структура в Solution Explorer](<img width="531" height="1055" alt="image" src="https://github.com/user-attachments/assets/6dcb4736-d966-407d-977c-2906d06f7f9c" />)

Вся логика игры вынесена в общую библиотеку **GeniyIdiot.Common**. Консольная и WinForms версии используют её, но имеют собственные интерфейсы.

---

## 🚀 Как запустить

**Что нужно:** [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) или свежее.

### Консольная версия
```bash
git clone https://github.com/RyuuDragon/GeniyIdiot.git
cd GeniyIdiot/GeniyIdiot.ConsoleApp
dotnet run
```

WinForms версия

```bash
cd GeniyIdiot/GeniyIdiot.WinFormsApp
dotnet run
```

Или просто откройте GeniyIdiot.sln в Visual Studio и запустите нужный проект.

---

🖼️ Как это выглядит

| Консоль | WinForms |
|---|---|
| <img width="1740" height="928" alt="2026-05-07_22-07-42" src="https://github.com/user-attachments/assets/08f199aa-6255-4599-9ab8-6f615baaf3e5" /> | <img width="955" height="650" alt="image" src="https://github.com/user-attachments/assets/15e8f5b6-6f84-49f1-bc4e-0654131821e2" /> |
| !(<img width="1737" height="925" alt="2026-05-07_22-05-40" src="https://github.com/user-attachments/assets/6472337f-a9fd-4448-abc1-21180707e069" />) | <img width="946" height="647" alt="2026-05-07_22-12-09" src="https://github.com/user-attachments/assets/be5907d7-2e6c-40c7-b74e-2a378cabdd54" /> |
---

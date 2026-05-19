# C# Desktop Translator Application

This project is a simple and fast NMT (Neural Machine Translation) based translation tool developed as part of a weekly desktop application development series. It utilizes the open-source **LibreTranslate API** for translation operations.

## 🚀 Features

* **API Integration:** Uses the `HttpClient` class to send HTTP requests to external services.
* **JSON Parsing:** Deserializes and processes API responses using the `Newtonsoft.Json` package.
* **Asynchronous Architecture:** Built with `async/await` to ensure the user interface (UI) remains fully responsive and doesn't freeze during translation.
* **Dynamic Translation:** Instantly translates text entered in the left panel based on the selected source and target languages.

## 🌍 Supported Languages

The application currently supports translation between the following languages:
* English (`en`)
* Turkish (`tr`)
* German (`de`)
* French (`fr`)
* Spanish (`es`)
* Italian (`it`)
* Russian (`ru`)
* Arabic (`ar`)

## 🛠️ Technologies Used

* C# & Windows Forms
* .NET Framework / .NET Core
* Newtonsoft.Json (NuGet Package)
* LibreTranslate API

## ⚙️ Setup and Run

1. Open the project using Visual Studio.
2. Ensure the **Newtonsoft.Json** package is installed via `Tools > NuGet Package Manager`.
3. Build and run the application (`F5`).

---
*Developer: Ömer Faruk Kavuğubüyük*

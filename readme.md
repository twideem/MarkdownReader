# Markdown Reader

不用安裝擴充功能，也不用將檔案上傳到網站，就能用網頁瀏覽器看圖文化的 Markdown 格式文件。

## 需求

本應用程式適用內建了 .NET Framework 的 Windows 10 作業系統。

## 下載

請按 Code，再按 Download ZIP，即可下載本程式。

## 使用

將 Markdown 檔案拖曳到 bin.exe 程式圖示上，或者在命令提示字元輸入 bin.exe "Markdown 檔案名稱"。

你的 Windows 必須有預設瀏覽器，才能正常呼叫網頁瀏覽器顯示 Markdown 文件。

覺得本程式用起來不錯的話，可以用「開啟檔案」→「選擇其他應用程式」→「bin.exe」→「一律使用此應用程式」，以後點兩下 Markdown 檔案就能執行。

## 設定

你可以在 conf.js 設定組態，例如修改 CSS 樣式，或者設定 Showdown 和 highlight.js 功能。

預先設定過的項目有：背景顏色、文字顏色、頁面邊界、highlight.js 的配色主題。

## 更新

基本功能足矣，且檔案小的關係，本程式使用舊版 1.0.2 的 showdown.min.js。你可以在 https://showdownjs.com 下載新版的來替換，獲得更完善且豐富的核心功能。

程式碼高亮功能，亦使用舊版 8.9.1 的 highlight.min.js 與 tomorrow-night-eighties.min.css，你可以在 https://highlightjs.org 下載新版的來替換。

## 修改

你可以編輯 src.cs 檔案來修改程式碼，以 C# 5.0 語言設計你想要的程式功能。

直接執行 build.bat 即可編譯程式碼，本程式使用 Windows 10 內建的 C# 編譯器，無須安裝任何程式語言工具。
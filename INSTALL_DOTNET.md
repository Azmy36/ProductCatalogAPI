# Install .NET 8 SDK - Step by Step Guide

## Quick Install (Choose One Method)

### Method 1: Direct Download (Recommended)

1. **Open your browser** and go to:
   ```
   https://dotnet.microsoft.com/download/dotnet/8.0
   ```

2. **Download the SDK** (not just Runtime):
   - Click on **".NET 8.0 SDK"** section
   - Download **"x64"** installer for Windows (most common)
   - File will be named something like: `dotnet-sdk-8.0.xxx-win-x64.exe`

3. **Run the installer**:
   - Double-click the downloaded `.exe` file
   - Follow the installation wizard
   - Click "Install" and wait for it to complete

4. **Restart your terminal/PowerShell**:
   - Close your current PowerShell window
   - Open a NEW PowerShell window
   - This is important so it picks up the new PATH

5. **Verify installation**:
   ```powershell
   dotnet --version
   ```
   Should show: `8.0.xxx` (some version number)

---

### Method 2: Using winget (If Available)

Open PowerShell as Administrator and run:
```powershell
winget install Microsoft.DotNet.SDK.8
```

Then restart your terminal and verify:
```powershell
dotnet --version
```

---

### Method 3: Using Chocolatey (If You Have It)

```powershell
choco install dotnet-8.0-sdk
```

---

## After Installation - Test Your Project

Once `.NET SDK` is installed:

1. **Open NEW PowerShell** (important - restart it!)

2. **Navigate to your project**:
   ```powershell
   cd "C:\Users\youss\Desktop\Web\Assignment 2"
   ```

3. **Restore packages** (first time only):
   ```powershell
   dotnet restore
   ```

4. **Build the project**:
   ```powershell
   dotnet build
   ```
   Should show: `Build succeeded.`

5. **Run the project**:
   ```powershell
   dotnet run
   ```

6. **Open Swagger**:
   - The output will show: `Now listening on: https://localhost:5001`
   - Open browser: `https://localhost:5001/swagger`
   - You should see all 6 endpoints!

---

## Troubleshooting

### "dotnet is not recognized" after installation
- **Solution**: Close and reopen your PowerShell/terminal window
- The installer adds .NET to PATH, but existing terminals don't see it until restarted

### Still not working?
- Check if .NET is in PATH:
  ```powershell
  $env:PATH -split ';' | Select-String dotnet
  ```
- If nothing shows, you may need to manually add it or restart your computer

### Wrong version?
- Check what's installed:
  ```powershell
  dotnet --list-sdks
  ```
- Should show: `8.0.xxx [C:\Program Files\dotnet\sdk]`

---

## What You'll See When It Works

After `dotnet run`, you should see:
```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:5001
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
```

Then open `https://localhost:5001/swagger` in your browser!

---

## Need Help?

- Official .NET Install Guide: https://learn.microsoft.com/dotnet/core/install/windows
- Download Page: https://dotnet.microsoft.com/download/dotnet/8.0

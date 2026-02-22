# Step-by-Step: Submit Your Assignment to GitHub

Follow these steps to put your project on GitHub and submit it.

---

## 1. Install Git (if needed)

- Download: https://git-scm.com/download/win  
- Run the installer and use default options.  
- Restart your terminal/IDE after installing.

---

## 2. Create a GitHub Account (if needed)

- Go to https://github.com and sign up.  
- Verify your email if asked.

---

## 3. Create a New Repository on GitHub

1. Log in to GitHub.  
2. Click the **+** (top right) → **New repository**.  
3. Set:
   - **Repository name:** e.g. `Assignment2` or `Web-Assignment2`
   - **Description:** (optional) e.g. "ASP.NET Core Web API Assignment 2"
   - **Visibility:** Public (or Private if your course uses GitHub Classroom)
   - **Do not** check "Add a README", "Add .gitignore", or "Choose a license" (you already have a project).
4. Click **Create repository**.  
5. Leave the page open; you’ll need the repository URL (e.g. `https://github.com/YourUsername/Assignment2.git`).

---

## 4. Add a .gitignore for .NET

So that build outputs and IDE files are not committed:

1. In your project folder (`Assignment 2`), create a file named **`.gitignore`**.  
2. Put this content in it (or use the one provided in the project):

```gitignore
# Build
bin/
obj/
out/

# Visual Studio / Rider
.vs/
*.user
*.suo
*.userosscache
*.sln.docstates

# User-specific
*.rsuser
*.userprefs

# NuGet
*.nupkg
.nuget/
packages/

# ASP.NET
project.lock.json
project.fragment.lock.json
artifacts/

# Other
*.log
.DS_Store
```

Save the file.

---

## 5. Initialize Git and Push from Your Computer

Open **PowerShell** or **Command Prompt** and run these commands. Replace `YOUR_USERNAME` and `YOUR_REPO` with your GitHub username and repository name.

```powershell
# Go to your project folder
cd "c:\Users\youss\Desktop\Web\Assignment 2"

# Initialize Git
git init

# Add all files
git add .

# First commit
git commit -m "Initial commit: ASP.NET Web API Assignment 2 - Products and Categories"

# Rename branch to main (if your GitHub default is main)
git branch -M main

# Add your GitHub repo as remote (replace with your repo URL)
git remote add origin https://github.com/YOUR_USERNAME/YOUR_REPO.git

# Push to GitHub
git push -u origin main
```

- If Git asks for your **username**, use your GitHub username.  
- For **password**, use a **Personal Access Token (PAT)**, not your GitHub password.  
  - GitHub → **Settings** → **Developer settings** → **Personal access tokens** → **Tokens (classic)** → **Generate new token**.  
  - Give it a name, choose expiry, and check **repo**. Copy the token and paste it when Git asks for a password.

---

## 6. Verify on GitHub

1. Refresh your repository page on GitHub.  
2. You should see all project files (e.g. `Program.cs`, `Controllers/`, `Models/`, `Services/`, `Interfaces/`, etc.).  
3. Open the repo and click into folders to confirm structure.

---

## 7. Submit the Assignment (as required by your course)

- **If they ask for a link:** Send the repository URL (e.g. `https://github.com/YourUsername/Assignment2`).  
- **If they use GitHub Classroom:** Use the assignment link they gave you; it will create a repo for you. Then add this project’s content (e.g. clone that repo, copy your project files in, commit, and push).  
- **If they use a specific branch name:** Create and push that branch, e.g.  
  `git checkout -b submission`  
  `git push -u origin submission`  
  and submit that branch or the repo link.

---

## Quick Reference – Your Project Contents

| Item | Description |
|------|-------------|
| **Models** | `Product`, `Category` (in `Models/`) |
| **Interfaces** | `IProductService`, `ICategoryService` (in `Interfaces/`) |
| **Services** | `ProductService`, `CategoryService` (in `Services/`) |
| **Controllers** | `ProductsController`, `CategoriesController` (in `Controllers/`) |
| **Endpoints per controller** | **Products:** GET all, GET by id, POST add. **Categories:** GET all, GET by id, POST add. |
| **Swagger** | Available at `https://localhost:5001/swagger` when running |

---

## Troubleshooting

- **“dotnet not found”**  
  Install **.NET 8 SDK**: https://dotnet.microsoft.com/download  

- **“Permission denied” or “Authentication failed”**  
  Use a **Personal Access Token** as the password when Git asks.  

- **“Support for password authentication was removed”**  
  You must use a PAT; GitHub no longer accepts account passwords for Git over HTTPS.  

- **Large or unwanted files already committed**  
  Add them to `.gitignore`, then run:  
  `git rm -r --cached .`  
  `git add .`  
  `git commit -m "Apply .gitignore"`  
  `git push`

After you complete these steps, your assignment is on GitHub and ready to submit as your instructor requested.

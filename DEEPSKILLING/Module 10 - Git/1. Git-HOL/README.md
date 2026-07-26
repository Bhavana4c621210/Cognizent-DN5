# Git Hands-On Lab – Exercise 1

## Objective

This exercise demonstrates the basic Git workflow by creating a local Git repository and performing fundamental Git operations.

## Tools Used

- Git Bash
- GitHub
- Windows 11

## Steps Performed

1. Installed Git for Windows.
2. Configured Git username and email.
3. Created a local Git repository using `git init`.
4. Created a file named `welcome.txt`.
5. Added the file to the staging area using `git add`.
6. Committed the file using `git commit`.
7. Verified the repository status using `git status`.
8. Connected the local repository to GitHub.
9. Pushed the repository to GitHub.

## Git Commands Used

```bash
git init
git status
git add welcome.txt
git commit -m "Added welcome.txt"
git remote add origin <repository-url>
git branch -M main
git push -u origin main
```

## Output

- Successfully initialized a Git repository.
- Created and committed `welcome.txt`.
- Verified a clean working tree.
- Uploaded the project to GitHub.

## Repository Structure

```
GIT/
│── welcome.txt
│── README.md
```

## Author

**Bhavana Parupalli**

# Git Hands-On Lab – Exercise 4 (Merge Conflict Resolution)

## Objective

Learn how to resolve merge conflicts between branches using Git.

## Commands Used

```bash
git branch GitWork
git checkout GitWork

echo "<message>Hello from GitWork Branch</message>" > hello.xml
git add hello.xml
git commit -m "Added hello.xml in GitWork"

git checkout master

echo "<message>Hello from Master Branch</message>" > hello.xml
git add hello.xml
git commit -m "Added hello.xml in master"

git log --oneline --graph --decorate --all
git diff master GitWork

git merge GitWork

git add hello.xml
git commit -m "Resolved merge conflict in hello.xml"

git status

git branch
git branch -d GitWork

git log --oneline --graph --decorate
```

## Output

- Created a new branch.
- Added different versions of `hello.xml` in both branches.
- Created a merge conflict.
- Resolved the conflict successfully.
- Updated `.gitignore`.
- Deleted the merged branch.
- Verified commit history.

## Author

**Bhavana Parupalli**

# APBD TUTORIAL 2 GIT

## Why it used ort instead of fast-forward
Because both branches had new commits since they split

## The difference between merge and rebase
git merge creates a new commit, combining one from the main branch and 'to merge with' branch'
<br>
git rebase puts commits from another branch 'on top of' commits of the main branch 


### 1. When does Git perform a fast-forward and when is a merge commit created??
Fast-forward is performed when the target branch has no new commits since fork
<br>
Merge commit is created when both branches have new commits

### 2. What is a practical difference between merge and rebase?
Merge preserves history and rebase doesn't. Rebase rewrites commit history.

### 3. How was the conflict resolved in your repository?
The option that made more sense was chosen.
The **feature-conflict** branch changed code of one of the methods in the following way:
```C#
Console.Write("Please enter a single character: ");

Console.Write("Don't enter a single character: ");
```
while **main** did the following:
```C#
Console.Write("Please enter a single character: ");

Console.Write("Please please please enter a single character: ");
```
Keeping in mind that it was the code that was executed in case the user was supposed to
enter a character to continue using the application, the change in **feature-conflict** branch
makes no sense, so it was discarded in favour of changes on the **main** branch.

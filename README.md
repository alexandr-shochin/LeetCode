## LeetCode

Problem solutions for https://leetcode.com

| dotnet build |                                                                                           unit tests                                                                                          |
|-|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------:|
|[![](https://github.com/alexandr-shochin/LeetCode/actions/workflows/build-workflow.yml/badge.svg)](https://github.com/alexandr-shochin/LeetCode/actions/workflows/build-workflow.yml)|[![](https://github.com/alexandr-shochin/LeetCode/actions/workflows/unit-tests-workflow.yml/badge.svg)](https://github.com/alexandr-shochin/LeetCode/actions/workflows/unit-tests-workflow.yml)|

### Structure

```
src/LeetCode.Algorithms/{Difficulty}/{Topic}   - algorithmic problems
src/LeetCode.Concurrency/{Difficulty}          - concurrency problems
tests/LeetCode.UnitTests/...                   - mirrors the source tree
```

### Conventions

- Every solution lives in a `XxxSolution` class inside the namespace matching its folder
  (`LeetCode.Algorithms.<Difficulty>.<Topic>`), with a link to the original problem in the XML docs.
- Every solution has a matching `XxxSolutionTests` class with the same folder layout.
- Public signatures follow the LeetCode contract. Where the constraints forbid empty input and the
  method would otherwise return a sentinel value, invalid input is rejected with
  `ArgumentNullException` / `ArgumentException`.
- Collections compared in tests use `Should().Equal(...)` so that element order is verified.

### Solved problems

| # | Problem | Difficulty | Topic |
|--:|---------|:----------:|-------|
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | Easy | Arrays |
| 2 | [Add Two Numbers](https://leetcode.com/problems/add-two-numbers/) | Medium | Linked List |
| 9 | [Palindrome Number](https://leetcode.com/problems/palindrome-number/) | Easy | String |
| 13 | [Roman to Integer](https://leetcode.com/problems/roman-to-integer/) | Easy | String |
| 14 | [Longest Common Prefix](https://leetcode.com/problems/longest-common-prefix/) | Easy | String |
| 20 | [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | Easy | Stack |
| 21 | [Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/) | Easy | Linked List |
| 26 | [Remove Duplicates from Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array/) | Easy | Arrays |
| 27 | [Remove Element](https://leetcode.com/problems/remove-element/) | Easy | Arrays |
| 28 | [Find the Index of the First Occurrence in a String](https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/) | Easy | String |
| 35 | [Search Insert Position](https://leetcode.com/problems/search-insert-position/) | Easy | Arrays |
| 58 | [Length of Last Word](https://leetcode.com/problems/length-of-last-word/) | Easy | String |
| 66 | [Plus One](https://leetcode.com/problems/plus-one/) | Easy | Arrays |
| 67 | [Add Binary](https://leetcode.com/problems/add-binary/) | Easy | String |
| 69 | [Sqrt(x)](https://leetcode.com/problems/sqrtx/) | Easy | Math |
| 83 | [Remove Duplicates from Sorted List](https://leetcode.com/problems/remove-duplicates-from-sorted-list/) | Easy | Linked List |
| 100 | [Same Tree](https://leetcode.com/problems/same-tree/) | Easy | Tree |
| 101 | [Symmetric Tree](https://leetcode.com/problems/symmetric-tree/) | Easy | Tree |
| 104 | [Maximum Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree/) | Easy | Tree |
| 111 | [Minimum Depth of Binary Tree](https://leetcode.com/problems/minimum-depth-of-binary-tree/) | Easy | Tree |
| 125 | [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | Easy | String |
| 226 | [Invert Binary Tree](https://leetcode.com/problems/invert-binary-tree/) | Easy | Tree |
| 240 | [Search a 2D Matrix II](https://leetcode.com/problems/search-a-2d-matrix-ii/) | Medium | Array |
| 394 | [Decode String](https://leetcode.com/problems/decode-string/) | Medium | Stack |
| 1114 | [Print in Order](https://leetcode.com/problems/print-in-order/) | Easy | Concurrency |
| 1115 | [Print FooBar Alternately](https://leetcode.com/problems/print-foobar-alternately/) | Medium | Concurrency |

### Local development

```bash
dotnet restore --locked-mode
dotnet build --configuration Release --no-restore
dotnet test --no-restore --configuration Release
dotnet format --verify-no-changes --no-restore
```

Package versions are pinned centrally in `Directory.Packages.props` and locked per project in
`packages.lock.json`, so `--locked-mode` restore is reproducible.

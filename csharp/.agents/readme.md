# Problem README Rules

## Preferred Implementation Rules

Preferred implementation must not be represented by moving files.

To mark the best, recommended, or currently preferred implementation, update the problem `README.md`.

The preferred implementation is informational only.

Example:

```md
## Preferred implementation

TwoPointers
```

Do not:

* move implementation files just to mark a different approach as preferred
* duplicate one implementation into another directory just to mark it as preferred
* create `Best`, `Preferred`, `Optimal`, or `Main` directories unless explicitly requested
* use physical location as a ranking mechanism

When the user says a solution is better, preferred, main, recommended, or optimal:

* update the problem `README.md`
* mark that approach as preferred
* do not move files
* do not rename directories
* do not duplicate implementations

## Problem README Rules

Each problem directory should contain a `README.md`.

The `README.md` should be minimal and factual.

Example:

```md
# LeetCode 11. Container With Most Water

https://leetcode.com/problems/container-with-most-water/

## Preferred implementation

TwoPointers

## Implementations

| Implementation | Time | Space | Status |
|---|---:|---:|---|
| BruteForce | O(n^2) | O(1) | Reference |
| TwoPointers | O(n) | O(1) | Preferred |
```

Rules:

* use the official LeetCode problem number and name
* include the LeetCode problem link
* list known implementations
* mark the preferred implementation when known
* use `Unknown` for time or space complexity if not known yet
* do not write long explanations unless explicitly requested
* do not turn the README into a tutorial unless explicitly requested

# Binary Search Tree Projesi
## Soru:  
[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.  

Örnek: root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.  

## Cevap
**Her düğümün sol alt ağacı, düğümden küçük değerler içerir.**  
**Her düğümün sağ alt ağacı, düğümden büyük değerler içerir.**  

- Root’u belirle
  - İlk eleman 7
- 5 ekle
  - 5 < 7 → 7’nin soluna gelir
- 1 ekle
  - 1 < 7 → sol
  - 1 < 5 → 5’in soluna gelir
- 8 ekle
  - 8 > 7 → 7’nin sağına gelir
- 3 ekle
  - 3 < 7 → sol
  - 3 < 5 → sol
  - 3 > 1 → 1’in sağına gelir
- 6 ekle
  - 6 < 7 → sol
  - 6 > 5 → 5’in sağına gelir
- 0 ekle
  - 0 < 7 → sol
  - 0 < 5 → sol
  - 0 < 1 → 1’in soluna gelir
- 9 ekle
  -  9 > 7 → sağ
  -  9 > 8 → 8’in sağına gelir
- 4 ekle
  - 4 < 7 → sol
  - 4 < 5 → sol
  - 4 > 1 → sağ
  - 4 > 3 → 3’ün sağına gelir
- 2 ekle
  - 2 < 7 → sol
  - 2 < 5 → sol
  - 2 > 1 → sağ
  - 2 < 3 → 3’ün soluna gelir
```
                                 7
                               /   \
                              5     8
                            /   \     \
                           1     6     9
                         /   \
                        0     3
                             / \
                            2   4  
```

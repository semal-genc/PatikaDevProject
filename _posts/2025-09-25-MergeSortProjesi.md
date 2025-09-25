# Merge Sort
## Soru  
[16,21,11,8,12,22] -> Merge Sort  

Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.
Big-O gösterimini yazınız.  

## Cevap
1. **Diziyi ikiye böl**
   - Sol = [16, 21, 11]
   - Sağ = [8, 12, 22]
2. **Sol diziyi tekrar böl**
   - [16, 21, 11] ➡️ [16] ve [21, 11]
   - [21, 11] ➡️ [21] ve [11]
3. Sol diziyi birleştirerek sırala
   - [21] ve [11] ➡️ [11, 21]
   - [16] ile birleştir ➡️ [11, 16, 21]
4. Sağ diziyi tekrar böl
   - [8, 12, 22] ➡️ [8] ve [12, 22]
   - [12, 22] ➡️ [12] ve [22]
5. Sağ diziyi birleştirerek sırala
   - [12] ve [22] ➡️ [12, 22]
   - [8] ile birleştir ➡️ [8, 12, 22]
6. Sol ve sağ dizileri birleştir
   - 8 < 11 = 8
   - 11 < 12 = 11
   - 12 < 16 = 12
   - 16 < 21 = 16
   - 21 < 22 = 21
   - 22 → 22  
**Sıralanmış dizi** = [8, 11, 12, 16, 21, 22]

import java.util.Scanner;

public class Main {
    static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int r;
        System.out.print("Dairenin Yarıçapını Giriniz: ");
        r = scanner.nextInt();
        System.out.print("Merkez açısını giriniz (derece): ");
        double alpha = scanner.nextDouble();

        double alan = Math.PI * r * r;
        double cevre = 2 * Math.PI * r;

        System.out.printf("Dairenin alanı: %.2f%n", alan);
        System.out.printf("Dairenin çevresi: %.2f%n", cevre);

        double yayUzunlugu = 2 * Math.PI * r * (alpha / 360.0);
        double dilimAlani = Math.PI * r * r * (alpha / 360.0);

        System.out.printf("Yay Uzunluğu %.2f%n", yayUzunlugu);
        System.out.printf("Daire Dilimi Alanı %.2f%n", dilimAlani);
    }
}

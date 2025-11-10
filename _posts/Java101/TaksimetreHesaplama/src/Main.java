import java.util.Scanner;

public class Main {
    static void main(String[] args) {
        float mesafe, km = 2.20f, taksimetre=10;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Kaç kilometre yol gideceksiniz: ");
        mesafe = scanner.nextFloat();

        taksimetre+=mesafe*km;

        if (taksimetre<=20)
            taksimetre=20;

        System.out.printf("Taksimetre Ücreti: %.2f%n",taksimetre);
    }
}

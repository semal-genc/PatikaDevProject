import java.util.Scanner;

public class Main {
    static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        float armutkg = 2.14f, elmakg = 3.67f, domateskg = 1.11f, muzkg = .95f, patlicankg = 5.0f;
        float armut, elma, domates, muz, patlican;
        System.out.print("Armut Kaç Kilo: ");
        armut = scanner.nextFloat();
        System.out.print("Elma Kaç Kilo: ");
        elma = scanner.nextFloat();
        System.out.print("Domates Kaç Kilo: ");
        domates = scanner.nextFloat();
        System.out.print("Muz Kaç Kilo: ");
        muz = scanner.nextFloat();
        System.out.print("Patlıcan Kaç Kilo: ");
        patlican = scanner.nextFloat();

        double toplamTutar = (armut * armutkg) + (elma * elmakg) + (domates * domateskg) + (muz * muzkg) + (patlican * patlicankg);
        System.out.printf("Toplam Tutar %.2f",toplamTutar);
    }
}

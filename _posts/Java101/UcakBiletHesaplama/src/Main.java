import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		double mesafe, normalTutar, indirimliTutar, toplamTutar = 0;
		int yas, yolculukTipi;

		System.out.print("Mesafeyi km türünden giriniz : ");
		mesafe = input.nextDouble();

		System.out.print("Yaşınızı giriniz : ");
		yas = input.nextInt();

		System.out.print("Yolculuk tipini giriniz (1 => Tek Yön , 2 => Gidiş Dönüş ): ");
		yolculukTipi = input.nextInt();

		if (mesafe <= 0 || yas <= 0 || (yolculukTipi != 1 && yolculukTipi != 2)) {
			System.out.println("Hatalı Veri Girdiniz !");
			return;
		}

		normalTutar = mesafe * 0.10;

		if (yas < 12) {
			indirimliTutar = normalTutar * 0.50;
			normalTutar -= indirimliTutar;
		} else if (yas >= 12 && yas <= 24) {
			indirimliTutar = normalTutar * 0.10;
			normalTutar -= indirimliTutar;
		} else if (yas > 65) {
			indirimliTutar = normalTutar * 0.30;
			normalTutar -= indirimliTutar;
		}

		if (yolculukTipi == 2) {
			indirimliTutar = normalTutar * 0.20;
			toplamTutar = (normalTutar - indirimliTutar) * 2;
		} else {
			toplamTutar = normalTutar;
		}

		System.out.println("Toplam Tutar = " + toplamTutar + " TL");
	}
}

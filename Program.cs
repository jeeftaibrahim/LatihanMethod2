int jumlahitem;

decimal hargaitem, diskon, totalbayar;

static decimal hitungdiskon(int jmlitem)
{
    if (jmlitem == 5) return 50000m;
    else if (jmlitem == 10) return 75000m;
    else return 0;
}

static decimal hitungtotal(int jmlitem, decimal hrgaitem, decimal diskonitem)
{
    return (jmlitem * hrgaitem - diskonitem);
}

Console.Write("Masukan Jumlah item:");
jumlahitem = int.Parse(Console.ReadLine());

Console.Write("Masukan harga item: ");
hargaitem = decimal.Parse(Console.ReadLine());

diskon = hitungdiskon(jumlahitem);

totalbayar = hitungtotal(jumlahitem, hargaitem, diskon);

Console.WriteLine($"total yang harus dibayar adalah Rp {totalbayar}");
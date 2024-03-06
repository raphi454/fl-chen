using Flaechen;

Dreieck d1 = new(8, 4);
Rechteck r1 = new(8, 5);
Quadrat q1 = new(4);

Gesamtfläche gesamt = new();
gesamt.Add(d1);
gesamt.Add(r1);
gesamt.Add(q1);
Console.WriteLine($"Die Gesamtfläche beträgt: {gesamt.GetFläche}");
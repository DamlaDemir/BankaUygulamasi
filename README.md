# Banka Uygulamasi

### Projenin Amacı ###

Bankaya gelen müşterilerin kuyrukta kalma sürelerini Döngüsel Kuyruk,Öncelik Kuyruğu(Büyükten Küçüğe),Öncelik Kuyruğu(Küçükten Büyüğe) gibi kuyruk yapıları kullanarak hesaplamak ve kuyruk yapılarındaki işlem tamamlanma sürelerini karşılaştırarak hangi kuyruk yapısının daha avantajlı olduğunu bulmak için yazılmış bir programdır.

### Proje Kapsamı ###

Proje kapsamında Döngüsel Kuyruk,Öncelik Kuyruğu(Büyükten Küçüğe),Öncelik Kuyruğu(Küçükten Büyüğe) gibi kuyruk yapılarına müşteri eklenebilmekte,işi biten müşteri kuyruktan çıkarılabilmektedir.Her bir müşterinin her bir kuyruk yapısındaki işlem tamamlanma süreleri bulunmakta ve müşterinin hangi kuyruk yapısında daha az beklediği tespit edilebilmektedir.Ayrıca her bir kuyruk için ortalama işlem tamamlanma süreleri bulunmakta ve bu süreler karşılaştırılarak kuyruk yapılarına göre elde edilen kazanç belirlenebilmektedir.

### Kullanılan Sınıflar ###

**IQueue Sınıfı:** Bir interface’dir.Insert() ,Remove(), Peek(),IsEmpty() foksiyonlarını içerir.

**Musteri Sınıfı:** Müşterinin, müşteri numarası ve işlem süresi gibi özelliklerini barındırır.

**CircularArrayTypedQueue Sınıfı:** IQueue interface’ini implemente eder.Döngüsel kuyruğa, kuyruğa girme sırasına göre müşteri ekleme,kuyruktan müşteri silme,her bir müşterinin işlem tamamlanma sürelerini hesaplama,her bir müşterinin müşteri numarası ,işlem süresi ,işlem tamamlanma süresi gibi bilgilerini geri döndürme ve tüm müşteriler için ortalama işlem tamamlanma süresini hesaplama gibi fonksiyonları barındırır.

**PriorityQueueBK Sınıfı:** IQueue interface’ini implemente eder.Öncelik kuyruğuna,işlem süresi büyük olan kuyruktan ilk çıkar mantığına göre  müşteri ekleme,kuyruktan müşteri silme,her bir müşterinin işlem tamamlanma sürelerini hesaplama,her bir müşterinin müşteri numarası ,işlem süresi ,işlem tamamlanma süresi gibi bilgilerini geri döndürme ve tüm müşteriler için ortalama işlem tamamlanma süresini hesaplama gibi fonksiyonları barındırır.

**PriorityQueueKB Sınıfı:** IQueue interface’ini implemente eder.Öncelik kuyruğuna,işlem süresi küçük olan kuyruktan ilk çıkar mantığına göre  müşteri ekleme,kuyruktan müşteri silme,her bir müşterinin işlem tamamlanma sürelerini hesaplama,her bir müşterinin müşteri numarası ,işlem süresi ,işlem tamamlanma süresi gibi bilgilerini geri döndürme ve tüm müşteriler için ortalama işlem tamamlanma süresini hesaplama gibi fonksiyonları barındırır.


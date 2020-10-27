# TheNextCar
aplikasi ini dapat menyalakan mesin dengan syarat kondisi pintu ditutup, pintu dikunci dan aki dinyalakan.

## Scope & Functionalities
- User dapat menyentuh tombol start
- user dapat menyentuh tombol ON/OFF
- User dapat menyentuh tombol LOCK

## How Does it works?
Diawali dari method `MainWindow` pada class  MainWindow.xaml.cs. 
cara mendeklarasikannya seperti berikut ,,,,

```csharp 
  public MainWindow()
        {
            InitializeComponent();

            AccubatteryController accubatteryController = new AccubatteryController(this);
            DoorController doorController = new DoorController(this);

            nextCar = new Car(doorController, accubatteryController, this);
        }
```
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class RepairRequestsViewModel : INotifyPropertyChanged
{
    public ObservableCollection<RepairRequest> RepairRequests { get; set; } = new ObservableCollection<RepairRequest>();

    // Метод для добавления новой заявки
    public void AddRepairRequest(RepairRequest request)
    {
        RepairRequests.Add(request);
        OnPropertyChanged(nameof(RepairRequests));
    }

    // INotifyPropertyChanged implementation
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
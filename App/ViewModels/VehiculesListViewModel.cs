using App.ViewModels;
using App.Models;

namespace App.Controllers
{
    internal class VehiculesListViewModel
    {
        private List<Vehicule> vehicle;
        private string v;

        public VehiculesListViewModel(List<Vehicule> vehicle, string v)
        {
            this.vehicle = vehicle;
            this.v = v;
        }
    }
}
using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Globalization;
using System.Xml;
using System.Reflection;
using System.Xml.Serialization;

public class NotifyBase : INotifyPropertyChanged
{
    #region NotifyBase
    // Declare the event
    public virtual event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(String propertyName)
    {
        if (PropertyChanged != null)
        {
            try
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
            catch
            {
                /*
                 * em CaixaSupermercado, apertar F8, digitar codigo 1, enter, ate adicionar, ai da erro:
                    NHibernate.LazyInitializationException: illegal access to loading collection
                       at NHibernate.Collection.AbstractPersistentCollection.Initialize(Boolean writing)
                       at NHibernate.Collection.Generic.PersistentGenericBag`1.System.Collections.Generic.IEnumerable<T>.GetEnumerator()
                       at Pedidos.CaixaSupermercado.ButtonAdicionarProduto_Click(Object sender, RoutedEventArgs e)
                 * */
            }
        }
    }
    #endregion
}
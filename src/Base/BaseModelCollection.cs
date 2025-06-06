﻿using System.Collections.ObjectModel;

namespace Bau.Libraries.LibDataStructures.Base;

/// <summary>
///		Colección de <see cref="BaseModel"/>
/// </summary>
public class BaseModelCollection<TypeData> : List<TypeData> where TypeData : BaseModel
{
	/// <summary>
	///		Busca un elemento por su clave numérica
	/// </summary>
	public virtual TypeData Search(int? id) => this.FirstOrDefault(item => item.Id == id);

	/// <summary>
	///		Busca un elemento
	/// </summary>
	public virtual TypeData Search(string id) => this.FirstOrDefault(item => (item.GlobalId ?? string.Empty).Equals(id, StringComparison.CurrentCultureIgnoreCase));

	/// <summary>
	///		Busca un elemento
	/// </summary>
	public TypeData Search(TypeData item) => this.FirstOrDefault(data => data.Id == item.Id);

	/// <summary>
	///		Comprueba si existe un dato
	/// </summary>
	public virtual bool Exists(int? id) => Search(id) is not null;

	/// <summary>
	///		Comprueba si existe un dato
	/// </summary>
	public virtual bool Exists(string id) => Search(id) is not null;

	/// <summary>
	///		Elimina un elemento de la colección
	/// </summary>
	public void RemoveById(int? id)
	{ 
		for (int index = Count - 1; index >= 0; index--)
			if (this[index].Id == id)
				RemoveAt(index);
	}

	/// <summary>
	///		Elimina un elemento por su ID
	/// </summary>
	public void RemoveById(string id)
	{
		TypeData item = Search(id);

			// Borra el elemento
			if (item != null)
				Remove(item);
	}

	/// <summary>
	///		Convierte la lista a un <see cref="ObservableCollection"/>
	/// </summary>
	public ObservableCollection<TypeData> ToObservableCollection()
	{ 
		ObservableCollection<TypeData> observable = [];

			// Traspasa la colección
			foreach (TypeData item in this)
				observable.Add(item);
			// Devuelve la colección
			return observable;
	}
}

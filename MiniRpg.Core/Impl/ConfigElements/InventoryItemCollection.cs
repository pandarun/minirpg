using System;
using System.Configuration;

namespace MiniRpg.Core
{

	public class InventoryItemCollection : ConfigurationElementCollection
	{
		public InventoryItemCollection()
		{
			// Add one item to the collection.  This is 
			// not necessary; could leave the collection  
			// empty until items are added to it outside 
			// the constructor.
			InventoryItemConfigElement item = 
				(InventoryItemConfigElement)CreateNewElement();
			Add(item);
		}

		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return 

					ConfigurationElementCollectionType.AddRemoveClearMap;
			}
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new InventoryItemConfigElement();
		}

		protected override ConfigurationElement CreateNewElement(string elementName)
		{
			return new InventoryItemConfigElement(elementName);
		}

		protected override Object GetElementKey(ConfigurationElement element)
		{
			return ((InventoryItemConfigElement)element).Name;
		}

		public new string AddElementName
		{
			get
			{ return base.AddElementName; }

			set
			{ base.AddElementName = value; }

		}

		public new string ClearElementName
		{
			get
			{ return base.ClearElementName; }

			set
			{ base.ClearElementName = value; }

		}

		public new string RemoveElementName
		{
			get
			{ return base.RemoveElementName; }
		}

		public new int Count
		{
			get { return base.Count; }
		}

		public InventoryItemConfigElement this[int index]
		{
			get
			{
				return (InventoryItemConfigElement)BaseGet(index);
			}
			set
			{
				if (BaseGet(index) != null)
				{
					BaseRemoveAt(index);
				}
				BaseAdd(index, value);
			}
		}

		new public InventoryItemConfigElement this[string Name]
		{
			get
			{
				return (InventoryItemConfigElement)BaseGet(Name);
			}
		}

		public int IndexOf(InventoryItemConfigElement item)
		{
			return BaseIndexOf(item);
		}

		public void Add(InventoryItemConfigElement item)
		{
			BaseAdd(item);
			// Add custom code here.
		}

		protected override void BaseAdd(ConfigurationElement element)
		{
			BaseAdd(element, false);
			// Add custom code here.
		}

		public void Remove(InventoryItemConfigElement item)
		{
			if (BaseIndexOf(item) >= 0)
				BaseRemove(item.Name);
		}

		public void RemoveAt(int index)
		{
			BaseRemoveAt(index);
		}

		public void Remove(string name)
		{
			BaseRemove(name);
		}

		public void Clear()
		{
			BaseClear();
			// Add custom code here.
		}
	}
	
}

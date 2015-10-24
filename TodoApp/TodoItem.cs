using System;

namespace TodoApp
{
	public class TodoItem : Bindable
	{

		private string _text;
		private bool _isCompleted;

		public string Text
		{
			get { return _text; }
			set
			{
				if (value == _text)
					return;

				_text = value;
				OnPropertyChanged ("Text");
			}
		}


		public bool IsCompleted
		{
			get { return _isCompleted; }
			set
			{
				if (value == _isCompleted)
					return;

				_isCompleted = value;
				OnPropertyChanged ("IsCompleted");
			}
		}
	}
}


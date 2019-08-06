﻿using System;

namespace HotUI
{
	public class SecureField : View
	{
        public SecureField(
            Binding<string> value = null,
            string placeholder = null,
            Action<string> onCommit = null)
        {
            Text = value;
            Placeholder = placeholder;
            OnCommit = onCommit;
        }

        Binding<string> _text;
        public Binding<string> Text
        {
            get => _text;
            private set => this.SetBindingValue(ref _text, value);
        }


        Binding<string> _placeholder;
		public Binding<string> Placeholder {
			get => _placeholder;
            private set => this.SetBindingValue(ref _placeholder, value);
        }
		
		public Action<string> OnCommit { get; set; }
	}
}

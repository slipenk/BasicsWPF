   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF.Views	WPF.Views  5      &     WPF.Views.FootballersUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WPF.Views     5        � 	Resources  5	      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%   '        �� 5
   
   "  6   .�5      ��  � ��$ Stretch=�64   �� 5       � ��$ Center=�6;   5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  $	��950��61   $	��Top=�6?   ��6X   ��  �� Path$ Footballers�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Прізвище��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6E   �� $
 Name�
 �� Mode$
 TwoWay=�  5      $ Ім'я��6%   $ * 63   	 6A   �� $ Surname�$
 TwoWay=�  5      $ Клуб��6%   $ * 63   	 6A   �� $ 	Club.Name�$
 TwoWay=�  5      $ 
Номер��6%   $ * 64   	 6@   �� $ Number�$
 TwoWay=�  5      $ Країна��6%   $ * 65   	 6B   �� $ Country�$
 TwoWay=�  5      $( "Вартість (млн євро)��6%   $ * 6B   	 6N   �� $ Value�$
 TwoWay=�5      5      5      
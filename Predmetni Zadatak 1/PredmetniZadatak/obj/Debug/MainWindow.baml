   M S B A M L   `   `   `  ����K  GPredmetniZadatak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PredmetniZadatakPredmetniZadatak  5   	   !    PredmetniZadatak.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PredmetniZadatak     5   	   -   5          � Title$  Hitovi 2000-ih��5   	    � WindowStyle$
 None=�6     � SizeToContent$ WidthAndHeight=�6d    � AllowsTransparency . 
������ .��5
      �� $	��800��6   $	��600��6    � 	Resources 5   
   3  -System.Windows.Media.Effects.DropShadowEffect   dropMouseOverShadowBlue   Color   	Direction   Opacity  dropMouseOverShadowRed��%�   &	        &	 :       5      $
 Blue��6?   $ 90Q�6L   $ 80Q�6[     5      $	 Red��6>   $ 90Q�6J   $ 80Q�6Y   5      .+�5   
   F� -   5        $��UIPath��5   1   
����  �$��3��6   ��5      �� 5       �� ImageSource$ MainJPG.jpg��6   ��5      B� 5      .��5      E� 	 E� 
StartPoint$	 250,0&�6!   .��5      �� 
 �� Point$
 125,45&�6&   �� 5      $	
 0,0&�6&   �� 5      $
 45,125&�6&   �� 5      $
 0,250&�6&   �� 5      $
 0,350&�6&   �� 5      $
 45,475&�6&   �� 5      $
 0,600&�6&   �� 5      $
 125,555&�6&   �� 5       $
 250,600&�6&   �� 5!      $
 650,600&�6&   �� 5"       �� Point$ 650,0&�6&    �� Size$ 100,200��64    �� RotationAngle$	 180Q�6C    �� 
IsLargeArc .  �� SweepDirection$ Counterclockwise=�6i   �� 5#      $
 250,0&�6&   5$      5%      5'      �� 5)   
   -   5         ��Name$ 	btnIzadji��5)      
����ح�$��Izadji��6;    �� Left$	 589��6d   
 �� Top$	 559��6v   $��31��6�   $��75��6�   ��5*      �� 5+       �� 
TargetType" ��6    �� Triggers 5,      P� 5-       P� Property �@J�IsMouseOver P� Value . . �5.      ��  �� Property �@J�Effect �� Value# [ 67   5/      51      53      �� 55   
   -   5        $ btnDodaj��55      
����ح�$��Dodaj��6:   $	 500��6a   $	 559��6s   $��31��6�   $��75��6�   ��56      �� 57      " ��6    58      P� 59       �@J�IsMouseOver . . �5:      ��  �@J�Effect# [  67   5;      5=      5?      &   System.Windows.Controls.DataGrid  5A   
   -   5          Name$ gridName��5A       J� Opacity$
 0.75Q�6%      AutoGenerateColumns .     CanUserReorderColumns .     CanUserResizeColumns .     SelectionMode$ Single=�6�      
IsReadOnly . $	��420��6�   $	��620��6�   $ 84��6�   $	 105��6�   ��64   �� *hitovi+    Columns  5B      4  .System.Windows.Controls.DataGridTemplateColumn  5D      ,  &System.Windows.Controls.DataGridColumn!   CanUserSort! .  "   Header$" Slika��6=   #   Width5  /System.Windows.Controls.DataGridLengthConverter$	# 120 6L   $   CellTemplate$ 5E      �� 5F      .R�5G      �� $	��100��6$   $	��100��61   $��Center=�6=   $
��Fill=�6Z   ��6i   �� *Slika+5H      5J      0  *System.Windows.Controls.DataGridTextColumn  5L      $" Naziv��6%   $	# 100 6N   1  +System.Windows.Controls.DataGridBoundColumn%   Binding% 64   �� *Naziv+&   ElementStyle& 5M      �� 5N      " ��6    .�5O      ��  � ��$ Center=�6B   �� 5P       � ��$
 Left=�6D   �� 5Q       � ��$
 Wrap=�6=   5R      5T        5V      $" Izvodjac��6%   $	# 100 6T   % 67   �� *
Izvodjac+& 5W      �� 5X      " ��6    .�5Y      ��  � ��$ Center=�6B   �� 5Z       � ��$
 Left=�6D   �� 5[       � ��$
 Wrap=�6=   5\      5^        5`      $" Duzina��6%   $# 60 6P   % 65   �� *Duzina+& 5a      �� 5b      " ��6    .�5c      ��  � ��$ Center=�6B   �� 5d       � ��$
 Left=�6D   5e      5g        5i      $" Datum��6%   $# 80 6l   % 64   �� *DatumObjavljivanja+' �� StringFormat$' d��& 5j      �� 5k      " ��6    .�5l      ��  � ��$ Center=�6B   �� 5m       � ��$
 Left=�6D   5n      5p        5r      $# * 6)   $ 5s      �� 5t      .R�5u      �� ( �� Orientation$( Vertical=�6)   $��Center=�6@   $��Center=�6]   .+�5v   "   �� $ btnProcitaj��6)   -   5        $��Procitaj��5v   >   $��80��6Q   $��30��6\   6h   �� 5w   "   �� 5x   "   $ 	btnIzmeni��6)   -   5        $��Izmeni��5x   <   $��80��6M   $��30��6X   6d   �� 5y   "   �� 5z   "   $ 	btnObrisi��6)   -   5        $��Obrisi��5z   <   $��80��6M   $��30��6X   6d   5{      5|      5~      5�      5�      5�      
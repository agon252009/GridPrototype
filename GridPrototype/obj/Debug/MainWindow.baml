   M S B A M L   `   `   `  ����H  DGridPrototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:GridPrototypeGridPrototype  5   	       GridPrototype.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5gridPrototypeclr-namespace:GridPrototype     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5	   	   ��  �� RelativeSource �� *Self+ � 	Resources 5       �� Source�� 5   
   $ Themes/Generic.xaml?�6   %    6<   .��5      � 
������� � ShowGridLines .  5   
   "   GridPrototype.SonovaGridCell �� 
TargetType   DefaultSonovaGridCellStyle �� BasedOn �� Property	 �� Value  CellValueTemplate  StringValueTemplate��%�   '        7   &	 O     &	 �     �� 5      "  6   8   .�5      ��  � ��
	 ��� �6>   5      �� 5      .R�5      �� ��6X   �� *Value+5      �� 5      .R�5      �� ��6X   �� *StringValue+5      5      
 � RowDefinitions
 5   
   �� 5      �� 5      .+�5    
   %   GridPrototype.GridCellPresenter  $��0��6*    67   �� *	ViewModel+   Cells 5"           SonovaGridCellTemplate# [ 6/     5#      # [ 6/   5%        5&   
   $��1��6*    67   �� *	ViewModel+ 5(        # [ 6/     5)      # [ 6/   5+      5,      5-      
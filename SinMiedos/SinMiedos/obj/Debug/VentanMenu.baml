   M S B A M L   `   `   `  ����D  @SinMiedos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SinMiedos	SinMiedos  5   	       SinMiedos.VentanMenu   5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SinMiedos     5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��14(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	    � Title$
 Menu��5   	   $	��600��6   $
��1024��6#    � WindowStyle$
 None=�60    � WindowStartupLocation$ CenterScreen=�6C    � 
ResizeMode$ NoResize=�6h    � Icon$ Imagenes/idea.png��6~   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   � $��1��6   $��1��6   ���	#FFEBF0F6.+�5       � -   5        $��
Contenedor��5      $�� ��6&   $
��auto��61   $
��auto��6>   	  � NavigationUIVisibility$	 Hidden=�6L   5       � 5"   
   
 � ShowGridLines
 .  $��1��6%   ���	#FF294473 5#      �� 5$      $	��125 �6    �� 5%      $��* �6     J� Effect 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(         
BlurRadius$ 20Q�6#      Color$ 	#FFDEDEDE��63      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]   .+�5+      � 
 .  ���	#FF294473.+�51      �� $��Imagenes/intellectual.png��6   $��75��6;   $��75��6G   $	��Top=�6R   �� 52      -   5        $��
txtUsuario��52   �   $��Center=�6   $��25��69   $��0,80,0,0q�6F   $��Alejandro Ortiz Tetecatl��6X   ���	#DDFFFFFF$��	Open Sans)�6�   $
��Bold"�6�   6�   �� 53      -   5        $��txtadministrador��53   �   $��Center=�6   $��25��69   $��0,80,0,0q�6F   ���	#DDFFFFFF$��	Open Sans)�6o   $
��Bold"�6�   $y�Hidden=�6�   �� 54      $	��125��6   $��3��6(   $��Center=�63   $��Bottom=�6P   $��0,0,0,7q�6k   ��55      �� 56       �� Color$ 	#FFFC73B5��6*   58      59      �� 5:      $��1��6   $��0q�6&   .+�5;      �� -   5         ��Name$ 	btnDoctor��5;      $
��0 10q�6,   ���	#FF2A4574���	#FF333399$��45��6i   .��5<      � $	��150��6   .+�5=      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Users=�62   $��Center=�6?   �� 5>      $��Center=�6$   $��Doctores��6A   $��Champagne & Limousines)�6Q   5?      5@      �� 5B      -   5        $ btnPaciente��5B      $
��0 10q�6.   ���	#FF2A4574���	#FF333399$��45��6k   .��5C      � $	��150��6   .+�5D        $ Account=�62   $��Center=�6A   �� 5E      $��Center=�6$   $��	Pacientes��6A   $��Champagne & Limousines)�6R   5F      5G      �� 5I      -   5        $ btnMonitoreo��5I      $
��0 10q�6/   ���	#FF2A4574���	#FF333399$��45��6m   .��5J      � $	��150��6   .+�5K        $ 
HeartPulse=�62   $��Center=�6D   �� 5L      $��Center=�6$   $��	Monitoreo��6A   $��Champagne & Limousines)�6R   5M      5N      �� 5P      -   5        $ 
btnReporte��5P      $�� 0 10q�6-   ���	#FF2A4574���	#FF333399$��45��6l   .��5Q      � $	��150��6   .+�5R        $ FileDocumentOutline=�62   $��Center=�6M   �� 5S      $��Center=�6$   $��Reportes��6A   $��Champagne & Limousines)�6Q   5T      5U      5W      5Z      � 5\   
   -   5         �Name$ GridBarraTitulo��5\      $��2��6(   ���	#FF294473
 .  .+�5]      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�5^      �� -	   5        $ btnSalir��5^       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6+   $��25��6q   $��25��6|   
���������6�   Z� ��6�   Z� .��5_        $ WindowMinimize=�6.   5`      � 5a      .+�5b      �� -
   5        $ btnMaximizar��5b      #��[ 63   $��25��6y   $��25��6�   
���������6�   Z� ��6�   Z� .��5c        $ WindowMaximize=�62   5d      �� 5f      -   5        $ 	btnNormal��5f      #��[ 60   $��25��6v   $��25��6�   
���������6�   Z� ��6�   Z� .��5g        $ WindowRestore=�62   5h      5i      �� 5k      -   5        $ btnMinimizar��5k      #��[ 6/   $��25��6u   $��25��6�   
���������6�   Z� ��6�   Z� .��5l        $ Power=�6.   5m      5o      5q      5s      5t      
   M S B A M L   `   `   `  ����D  @SinMiedos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SinMiedos	SinMiedos  5      !    SinMiedos.FormularioUsuario   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:SinMiedos     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  FormularioUsuario��5
      .��5      � $
��auto��6   $
��auto��6   ���	#FFEBF0F6.+�5   
   �� $��Paciente��6      MaterialDesignGroupBox#���   6&   $��16q�6W   $��18(�6c   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5   	   $��0q�6;   
������ $
��Bold"�6h   $��Open Sans Extrabold)�5   	   5      � 5   
   $��16,75,16,16q�6   
�������.+�5      )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ modal��5   (   $
��Auto��6k   $
��auto��6y      DialogContent 5      �� 5      $��16q�6!   .+�5      �� -   5         ��Name$ 	txtNombre��5   "   $
��0,10q�65   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre��6C    % !MaterialDesignFloatingHintTextBox#��[ 6k   $
��18px(�6�   �� 5       �� Orientation$ 
Horizontal=�6%   $
��auto��6>   $
��auto��6K   .+�5       �� -   5        $ 
txtPaterno��5    &   $
��0,10q�6:   $ Apellido paterno��6H   #��[ 6z   $
��18px(�6�   �� 5!      -   5        $ 
txtMaterno��5!   &   $
��4,10q�6:   $ Apellido materno��6H   #��[ 6z   $
��18px(�6�   5"      �� 5$      -   5        $ txtEdad��5$   "   $
��0,10q�63   $
 Edad��6A   #��[ 6g   $
��18px(�6�   �� 5%      -   5        $ txtTelefono��5%   "   $
��0,10q�67   $ Telefono��6E   #��[ 6o   $
��18px(�6�   �� 5&      -   5        $ txtDireccion��5&   "   $
��0,10q�68   $ 	Direccion��6F   #��[ 6q   $
��18px(�6�   �� 5'      -   5        $ txtEmail��5'   "   $
��0,10q�64   $ Correo electronico��6B   #��[ 6v   $
��18px(�6�   �� 5(      -	   5         ��Name$ cmbSexo��5(   #   $
 Sexo��64    & "MaterialDesignFloatingHintComboBox#��[ 6Z   $
��18px(�6�   .@�5)      �� .��6+   
Femenino5+      �� 5,      .��6+   	Masculino5.      5/      �� 50      -
   5         ��Name$ txtidPaciente��50   $   $
��0,10q�6;   $
��18px(�6I   $y�Hidden=�6Y   �� 52      $ 
Horizontal=�6%   $��Right=�6>   .+�53      �� -   5          MaterialDesignFlatButton#��[ 53   %   	 �� 	IsDefault	 . $��0 8 8 0q�6i   $2��,materialDesign:DialogHost.CloseDialogCommand��54   %   .��6\   	Aceptar56      �� 57      #��[ 6%   
 �� IsCancel
 . $��0 8 8 0q�6g   $2��,materialDesign:DialogHost.CloseDialogCommand��58      .��6T   
Cancelar5:      5;      5=      .��5A      � $
��Auto��6   $
��auto��6!   .+�5C      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5C   ;   $
��auto��6    $
��auto��6-   $��	0,0,0,9.6q�6N      AutoGenerateColumns .     
IsReadOnly .    Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 61      Header$ ID��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   ��  �� Path$ Id�  5F      $	 150 61   $ Nombre��6=    6M   �� $ Nombre�  5G      $	 150 61   $ Paterno��6=    6N   �� $ Paterno�  5H      $	 150 61   $ Materno��6=    6N   �� $ Materno�  5I      $	 100 61   $
 Sexo��6=    6K   �� $
 Sexo�4	  .System.Windows.Controls.DataGridTemplateColumn	  5K      $ Acciones��65    	  CellTemplate 5L   &   �� 5M   *   .R�5N   *   �� $ 
Horizontal=�65   $��Center=�6N   $
��10,0q�6k   .+�5O   2   �� -   5        $��10q�5O   9    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6E      OpenDialogCommand#��Z 6�   $��25��6�   $��25��6�   
����������	#FF47BE7A���	#FF47BE7A.��5P   2   '
  !MaterialDesignThemes.Wpf.PackIcon
  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$
 Edit=�6J   5Q   /   �� 5R   .   -   5        $��10q�5R   5   #��[ 6A   $��25��6�   $��25��6�   
����������	#FFC23B22���	#FFC23B22.��5S   2   
  $ Close=�6J   5T   /   5U   +   5V   '   5Y   #   5\      �� 5`      -   5        #��[ 5`      #��Z 5a      $ Depth4=�5b      $��Bottom=�5c      $��Right=�5e      $��0��65   $��0,0,20,24.8q�6B   .��5f      
  $
 Plus=�62   $��22��6>   $��22��6J   5g      5i      5j      5k      5o      5p      
   M S B A M L   `   `   `  ����C  ?Language, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LanguageLanguage  5   	       Language.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Language     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1200��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowState$ 	Maximized=�6[   .��5
      � 
�����w�.+�5   
   �� $��50q�6   
������� �� CornerRadius$ 60��63    �� Padding$ 60q�6E    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 60Q�6#      ShadowDepth$ 0Q�63      Color$ 
Aquamarine��6C   ._�5      � 	 � RowDefinitions	 5      �� 5      $��40 �6$   62   �� 5      $��* �6$   61   .+�5      �� 
 �� Orientation$
 
Horizontal=�6   .+�5      �� -   5         ��Name$ kolvoBox��5      $��0 0 20 0q�61    �� Text$ Все��6C   $
��Left=�6N   $��0��6�   �� 5      -   5         ��Name$ 
BackButton��5      $+��%Предыдущая страница��6J   $��0 0 20 0q�6h   �� 5      -   5        $ 
NextButton��5      $)��#Следующая страница��6J   $��0 0 20 0q�6g   �� 5      -   5        $ AddPhoto��5      $+��%Добавить фотографию��6F   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridClient��5   -      
IsReadOnly .    AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6a   $��1��6q      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  Идентификатор��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *ID+  5      $ Имя��6-    6:   �� *	FirstName+  5      $ Фамилия��6-    6>   �� *
LastName+  5      $ Отчество��6-    6?   �� *
Patronymic+  5       $ Дата рождения��6-    6D   �� *
Birthday+  5!      $ Пол��6-    6:   �� *Gender.Name+  5"      $ Телефон��6-    6>   �� *Phone+  5#      $2 ,Адрес электронной почты��6-    6N   �� *Email+  5$      $% Дата регистрации��6-    6G   �� *RegistrationDate+  5%      $6 0Дата последнего посещения��6-    6P   �� *DateOfLastVisit+  5&      $$ Кол-во посещений��6-    6G   �� *NumberOfVisits+5(      5)      5*      5+      5,      
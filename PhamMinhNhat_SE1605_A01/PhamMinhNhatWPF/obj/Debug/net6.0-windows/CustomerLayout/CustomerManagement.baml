   M S B A M L   `   `   `  ����J  FPhamMinhNhatWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:PhamMinhNhatWPF.CustomerLayoutPhamMinhNhatWPF.CustomerLayout  5   	   7    1PhamMinhNhatWPF.CustomerLayout.CustomerManagement   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:PhamMinhNhatWPF.CustomerLayout     5   	   -   5          � Title$  CustomerManagement��5	   	   $	��679��6$   $	��690��61    � WindowStartupLocation$ CenterScreen=�6=   .��5
      � .+�5   
   ]� $	��Top=�6   $��10q�6,   .+�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $��4 �6$   �� 5      $��* �6$   .+�5      �� 
����ح� �� Orientation$ Vertical=�64   $
��Left=�6K   $	��400��6f   .+�5      �� $��Customer ID��6   �� 5      -   5        $��txtCustomerID��5      $��Stretch=�63   $��25��6Q   ${�false��5   a   ��5      ��  �� Path$ 
CustomerId� �� Mode$ OneWay=� � DataContext 5      ��  �� ElementName$ lvCustomers��$ SelectedItem�6a   �� 5      $��Email��6   �� 5      -   5        $��txtEmail��5      $��Stretch=�6.   $��25��6L   ${�false��5   a   ��5      �� $ Email�$ OneWay=� 5      �� $ lvCustomers��$ SelectedItem�6a   �� 5      $��Customer Name��6   �� 5      -   5        $��txtCustomerName��5      $��Stretch=�65   $��25��6S   ${�false��5    a   ��5      �� $ CustomerName�$ OneWay=� 5       �� $ lvCustomers��$ SelectedItem�6a   �� 5!      $
��City��6   �� 5"      -   5        $��txtCity��5"      $��Stretch=�6-   $��25��6K   ${�false��5$   a   ��5#      �� $
 City�$ OneWay=� 5$      �� $ lvCustomers��$ SelectedItem�6a   �� 5%      $��Country��6   �� 5&      -   5        $��
txtCountry��5&      $��Stretch=�60   $��25��6N   ${�false��5(   a   ��5'      �� $ Country�$ OneWay=� 5(      �� $ lvCustomers��$ SelectedItem�6a   �� 5)      $��Birthday��6   �� 5*      -   5        $��txtBirthday��5*      $��Stretch=�61   $��25��6O   ${�false��5,   a   ��5+      �� $ Birthday�$ OneWay=� 5,      �� $ lvCustomers��$ SelectedItem�6a   5-      �� 5/      $��1��6   $ 
Horizontal=�6*   $
��Left=�6C   .+�50      �� -   5         ��Name$ btnLoad��50      $��10q�6.   $��80��6:   $
��Load��6E   6T   �� 51      -	   5        $ 	btnInsert��51      $��10q�60   $��80��6<   $��Insert��6G   6X   �� 52      -
   5        $ 	btnUpdate��52      $��10q�60   $��80��6<   $��Update��6G   �� 53      -   5        $ 	btnDelete��53      $��10q�60   $��80��6<   $��Delete��6G   6X   54      �� 56      -   5        $��lvCustomers��56   (   $��2��6   $
��Auto��6;   $��
8,0,0,-124q�6I   $��2��6]   	 �� View	 57      �� 58      .P�59      �� $��Customer ID��6-   
 �� Width$	
 100��6B    �� DisplayMemberBinding 6N   �� $ 
CustomerId��� 5:      $��Email��6-   $	
 100��6<    6H   �� $ Email��� 5;      $��Customer Name��6-   $	
 100��6D    6P   �� $ CustomerName��� 5<      $
��City��6-   $	
 100��6;    6G   �� $
 City��� 5=      $��Country��6-   $	
 100��6>    6J   �� $ Country��� 5>      $��Birthday��6-   $	
 100��6?    6K   �� $ Birthday�5?      5A      5B      5C      5D      5E      
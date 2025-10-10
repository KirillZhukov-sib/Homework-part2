using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Class1
    {


        /*
         <Window x:Class="Lesson_7.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Lesson_7"
        mc:Ignorable="d"
        Title="MainWindow" Height="226" Width="428">

    <Window.Resources>
        <!-- Кастомный ControlTemplate для CheckBox -->
        <ControlTemplate x:Key="ThreeStateCheckBoxTemplate" TargetType="CheckBox">
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="Auto"/>
                </Grid.RowDefinitions>

                <!-- Контейнер для визуальных элементов -->
                <Border Grid.Row="0" 
                    Width="40" Height="40"
                    Background="Transparent">

                    <!-- Основной прямоугольник -->
                    <Rectangle x:Name="checkBoxRect" 
                           Width="30" Height="30"
                           Stroke="#FF707070"
                           StrokeThickness="2"
                           RadiusX="3" RadiusY="3"
                           Fill="White"/>

                    <!-- Буква "X" для состояния Checked -->
                    <TextBlock x:Name="checkMark"
                           Text="X"
                           FontWeight="Bold"
                           FontSize="14"
                           Foreground="#FF0078D7"
                           HorizontalAlignment="Center"
                           VerticalAlignment="Center"
                           Opacity="0"/>

                    <!-- Круг для состояния Indeterminate -->
                    <Ellipse x:Name="indeterminateCircle"
                         Width="12" Height="12"
                         Fill="#FF0078D7"
                         HorizontalAlignment="Center"
                         VerticalAlignment="Center"
                         Opacity="0"/>
                </Border>

                <!-- Текст CheckBox (под квадратом) -->
                <TextBlock Grid.Row="1"
                       x:Name="contentPresenter"
                       Text="{TemplateBinding Content}"
                       HorizontalAlignment="Center"
                       Margin="0,8,0,0"
                       TextWrapping="Wrap"
                       TextAlignment="Center"
                       MaxWidth="80"/>
            </Grid>

            <ControlTemplate.Triggers>
                <!-- Триггер для состояния Checked -->
                <Trigger Property="IsChecked" Value="True">
                    <Setter TargetName="checkMark" Property="Opacity" Value="1"/>
                    <Setter TargetName="checkBoxRect" Property="Stroke" Value="#FF0078D7"/>
                </Trigger>

                <!-- Триггер для состояния Indeterminate -->
                <Trigger Property="IsChecked" Value="{x:Null}">
                    <Setter TargetName="indeterminateCircle" Property="Opacity" Value="1"/>
                    <Setter TargetName="checkBoxRect" Property="Stroke" Value="#FF0078D7"/>
                </Trigger>

            </ControlTemplate.Triggers>
        </ControlTemplate>
    </Window.Resources>

    <!-- ОСНОВНОЙ КОНТЕЙНЕР -->
    <Grid>
        <!-- Горизонтальное расположение CheckBox -->
        <StackPanel Orientation="Horizontal" 
                VerticalAlignment="Center" 
                HorizontalAlignment="Center"
                Margin="20">

            <!-- CheckBox в состоянии Unchecked -->
            <CheckBox Content="Unchecked" 
                  IsChecked="False"
                  Margin="20,0"/>

            <!-- CheckBox в состоянии Checked -->
            <CheckBox Content="Checked" 
                  IsChecked="True"
                  Margin="20,0"/>

            <!-- CheckBox в состоянии Indeterminate -->
            <CheckBox Content="Indeterminate" 
                  IsChecked="{x:Null}"
                  Margin="20,0"/>
        </StackPanel>
    </Grid>
</Window>

          
          
          
         */








    }
}

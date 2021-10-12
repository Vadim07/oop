#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_pushButton_clicked()
{
    QString s = ui -> lineEdit ->text();
    a = s.toFloat();
    S = 0;
    B = 0;
    if(a>0){
       S = a*a*6;
       B = a*a*a;
    }


    ui -> label_S -> setText(QString::number(S));
    ui -> label_B -> setText(QString::number(B));
}


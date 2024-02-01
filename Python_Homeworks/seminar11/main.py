''''
pip install jupyter
jupyter notebook
pip install jupyter_http_over_ws
jupyter server extension enable --py jupyter_http_over_ws

pip install colabcode and vs C++ tools

pip install versioneer
jupyter notebook NotebookApp.allow_origin='https://colab.research.google.com' port=8888 NotebookApp.port_retries=0'''
from sympy import *
import pandas as pd

#df = pd.read_csv('california_housing_train.csv')

from colabcode import ColabCode
from google.colab import drive
drive.mount('/content/drive')
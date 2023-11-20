import React, { useEffect } from "react";
import Box from "@mui/material/Box";
import MenuItem from "@mui/material/MenuItem";
import Grid from "@mui/material/Grid";
import { Typography } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import { fetchEjemplo, fetchTipoMoneda } from '../../Store/Features/TablaEjemplo/TablaEjemploSlice';
import Button from '@mui/material/Button';
import { useForm } from "react-hook-form";
import ControlledTextField from "../Molecules/ControlledTextField";
import ControlledCheckbox from "../Molecules/ControlledCheckbox";
import ControlledSelect from "../Molecules/ControlledSelect";

const initialHeatSinkValues = () => {
  return {
    IdTablaEjemplo: 1,
    NombreEjemplo: "",
    NumeroEjemplo: 1,
    BooleanoEjemplo: false,
    DropdownEjemplo: "",
  };
};

export default function Body() {
  const {
    TipoMoneda,
  } = useSelector((state) => ({
    TipoMoneda: state?.ejemplos?.tipoMonedas,
  }));

  const dispatch = useDispatch();

  const { handleSubmit, control, setValue } = useForm({
    defaultValues: 
      initialHeatSinkValues()
    ,
  });

  useEffect(() => {
      dispatch(fetchTipoMoneda({}));
  }, []);

  const submitHandler = async (event) => {
    await dispatch(fetchEjemplo({...event}));
  };

  return (
    <Box
      onSubmit={submitHandler}
      component="form"
      sx={{
        flexGrow: 1,
        "& .MuiTextField-root": { m: 1, width: "25ch" },
      }}
      noValidate
      autoComplete="off"
    >
      <Grid container spacing={2}>
        <Grid item xs={6} md={12}></Grid>
        <Grid item xs={6} md={12}>
          <Typography>Formulario principal</Typography>
        </Grid>
        <Grid item xs={6} md={3}></Grid>
        <Grid item xs={6} md={6}>
          <ControlledTextField
            fieldName="IdTablaEjemplo"
            label="IdTablaEjemplo"
            control={control}
            type="text"
            fullWidth
          />
          <ControlledTextField
            fieldName="NombreEjemplo"
            label="NombreEjemplo"
            control={control}
            type="text"
            fullWidth
          />
          <ControlledTextField
            fieldName="NumeroEjemplo"
            label="NumeroEjemplo"
            control={control}
            type="number"
            fullWidth
          />
          <ControlledCheckbox
            fieldName="BooleanoEjemplo"
            label="BooleanoEjemplo"
            control={control}
          />
          <ControlledSelect
            fieldName="DropdownEjemplo"
            label="DropdownEjemplo"
            control={control}
            fullWidth
            onChange={(evt) => {
              const { value } = evt.target;
              setValue("DropdownEjemplo", value);
            }}
          >
            {TipoMoneda.map((option) => (
              <MenuItem key={option.idTipoMoneda} value={option.idTipoMoneda}>
                {option.texto}
              </MenuItem>
            ))}
          </ControlledSelect>
          <Button variant="contained" type="submit" onClick={handleSubmit(submitHandler)}>Guardar</Button>
        </Grid>
        <Grid item xs={6} md={3}></Grid>
      </Grid>
    </Box>
  );
}

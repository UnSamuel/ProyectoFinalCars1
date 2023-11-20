import React from "react";
import { Controller } from "react-hook-form";
import { Box, TextField, Typography, useTheme } from "@mui/material";

const ControlledTextField = ({
  control,
  fieldName,
  rules,
  helperMessage,
  measurementUnit,
  ...textFieldProps
}) => {
  const { palette } = useTheme();

  const ControlledInput = (props) => {
    return <TextField {...props} />;
  };

  return (
    <Controller
      name={fieldName}
      control={control}
      rules={rules}
      render={({ field, fieldState: { error } }) => (
        <ControlledInput
          error={!!error}
          helperText={error ? helperMessage || error.message : null}
          InputProps={{
            endAdornment: measurementUnit && (
              <Box
                sx={{
                  bgcolor: palette.primary.main200,
                  p: "3px",
                  width: "100%",
                  textAlign: "center",
                }}
              >
                <Typography
                  variant="caption"
                  fontWeight={600}
                  color={palette.primary.main}
                >
                  {measurementUnit}
                </Typography>
              </Box>
            ),
          }}
          {...{ ...field, ...textFieldProps }}
        />
      )}
    />
  );
};

export default ControlledTextField;